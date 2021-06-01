using Android.App;
using Android.Content;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// The BarcodeReader class represents a barcode reader device. It provides
    /// the following features:
    /// <list type="bullet">
    /// <item>
    /// <description>Gets a listed of connected barcode readers.</description>
    /// </item>
    /// <item>
    /// <description>Opens or closes a connection to an internal barcode reader or a
    /// supported external barcode reader such as the ring scanner for Dolphin 75e.</description>
    /// </item>
    /// <item>
    /// <description>Receives scanned barcode data via events.</description>
    /// </item>
    /// <item>
    /// <description>Programmatically triggers the scanner.</description>
    /// </item>
    /// <item>
    /// <description>Configures the symbology and decoder settings.</description>
    /// </item>
    /// </list>
    /// </summary>
    public class BarcodeReader : BarcodeReaderBase
    {
        private Com.Honeywell.Aidc.BarcodeReader mAidcBarcodeReader;
        private Com.Honeywell.Aidc.AidcManager mAidcManager;
        private BarcodeEventHandler mBarcodeEventHandler;
        private bool mReaderOpened;
        internal const string LOG_TAG = "BarcodeReader";
        private static BarcodeDeviceEventHandler sBarcodeDeviceEventHandler;
        private static readonly object mOpenLock = new object();

        //Not static as we are just checking our current class isn't resetting
        private readonly object mProfileFixLock = new object();

        public const string DEFAULT_PROFILE = "DEFAULT";

        public string CurrentProfile { get; internal set; } = null;

        /// <summary>
        /// Gets a boolean value indicating whether the barcode reader is opened.
        /// </summary>
        public override bool IsReaderOpened
        {
            get
            {
                lock (mProfileFixLock)
                {
                    return mReaderOpened;
                }
            }
        }

        /// <summary>
        /// Creates a BarcodeReader object for accessing the internal scanner.
        /// </summary>
        /// <param name="context">This is an optional parameter default to null.
        /// On Android platform, it will use Android.App.Application.Context if
        /// the parameter value is null. If the parameter is not null, then it
        /// needs to be a type of Android.Content.Context. It can
        /// be either an activity or application context.</param>
        /// <exception cref="T:System.ArgumentException">Invalid context parameter.</exception>
        /// <example>
        /// <code>
        /// using DevFromDownUnder.Honeywell.DataCollection.BarcodeReader;
        /// BarcodeReader mBarcodeReader = new BarcodeReader();
        /// </code>
        /// </example>
        public BarcodeReader(object context = null) : base(context)
        {
            if (context == null)
            {
                mContext = Application.Context;
            }
            else if (!(context is Context))
            {
                throw new ArgumentException("Invalid context type, must be Android.Content.Context.", "context");
            }

            mScannerName = "dcs.scanner.imager";
            SetBarcodeDeviceListener(mContext);
        }

        /// <summary>
        /// Creates a BarcodeReader object for accessing the specified scanner.
        /// For the scannerName parameter, use one of the scanner names returned
        /// from the <see cref="M:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.GetConnectedBarcodeReaders(System.Object)" /> method
        /// or null for the internal scanner.
        /// </summary>
        /// <param name="scannerName">A string to identify the scanner that this
        /// object represents and operates on.</param>
        /// <param name="context">This is an optional parameter default to null.
        /// On Android platform, it will use Android.App.Application.Context if
        /// the parameter value is null. If the parameter is not null, then it
        /// needs to be a type of Android.Content.Context. It can
        /// be either an activity or application context.</param>
        /// <exception cref="T:System.ArgumentException">Invalid context parameter.</exception>
        public BarcodeReader(string scannerName, object context = null) : base(scannerName, context)
        {
            if (context == null)
            {
                mContext = Application.Context;
            }
            else if (!(context is Context))
            {
                throw new ArgumentException("Invalid context type, must be Android.Content.Context.", "context");
            }

            if (scannerName == null)
            {
                mScannerName = "dcs.scanner.imager";
            }

            SetBarcodeDeviceListener(mContext);
        }

        /// <summary>
        /// Sets the AddBarcodeDeviceListener for device connection status.
        /// </summary>
        /// <param name="context">This parameter needs to be a type of Android.Content.Context.
        /// It can be an activity or application context.</param>
        private void SetBarcodeDeviceListener(object context)
        {
            if (sBarcodeDeviceEventHandler != null)
            {
                return;
            }

            Task.Run(() =>
            {
                lock (mProfileFixLock)
                {
                    lock (mOpenLock)
                    {
                        using var barcodeReaderManager = BarcodeReaderManager.Create((Context)context);

                        if (mAidcManager == null)
                        {
                            mAidcManager = barcodeReaderManager.Init();
                        }
                    }

                    sBarcodeDeviceEventHandler = new BarcodeDeviceEventHandler(this);
                    mAidcManager.AddBarcodeDeviceListener(sBarcodeDeviceEventHandler);
                }
            });
        }

        /// <summary>
        /// Opens the barcode reader specified in the constructor.
        /// </summary>
        /// <example>
        /// <code>
        /// using DevFromDownUnder.Honeywell.DataCollection.BarcodeReader;
        /// BarcodeReader mBarcodeReader = new BarcodeReader();
        /// BarcodeReader.Result result = await mBarcodeReader.OpenAsync();
        /// if (result.Code == BarcodeReader.Result.Codes.SUCCESS)
        /// {
        ///     // Barcode reader was successfully opened. You may invoke other methods
        ///     // of the BarcodeReader object to interact with the reader.
        /// }
        /// </code>
        /// </example>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public override async Task<Result> OpenAsync()
        {
            Logger.Debug("BarcodeReader", "OpenAsync entry");

            var result = await Task.Run(() =>
            {
                lock (mProfileFixLock)
                {
                    return OpenReader(mScannerName, (Context)mContext);
                }
            });

            Logger.Info("BarcodeReader", "OpenAsync returns Code:" + result.Code + " Message:" + result.Message);

            return result;
        }

        private Result OpenReader(string scannerName, Context context)
        {
            var result = new Result(Result.Codes.SUCCESS, "Reader successfully claimed.");
            if (!mReaderOpened)
            {
                try
                {
                    if (mAidcBarcodeReader == null)
                    {
                        lock (mOpenLock)
                        {
                            var manager = BarcodeReaderManager.Create(context);

                            if (manager != null)
                            {
                                mAidcManager = manager.Init();
                                mAidcBarcodeReader = mAidcManager.CreateBarcodeReader(scannerName);
                                try
                                {
                                    mAidcBarcodeReader.SetProperty("TRIG_CONTROL_MODE", "autoControl");
                                }
                                catch (Com.Honeywell.Aidc.UnsupportedPropertyException)
                                {
                                    result.Code = Result.Codes.INTERNAL_ERROR;
                                    result.Message = "Failed to set trigger control mode.";
                                }

                                if (result.Code == Result.Codes.SUCCESS)
                                {
                                    mBarcodeEventHandler = new BarcodeEventHandler(this);
                                    mAidcBarcodeReader.AddBarcodeListener(mBarcodeEventHandler);
                                }
                            }
                            else
                            {
                                result.Code = Result.Codes.INTERNAL_ERROR;
                                result.Message = "Manager has been disposed.";
                            }
                        }
                    }
                    if (result.Code == Result.Codes.SUCCESS)
                    {
                        try
                        {
                            mAidcBarcodeReader.Claim();
                            mReaderOpened = true;

                            BarcodeReaderProfileHandler.Instance.LoadProfileOccurred += LoadProfileOccurred;
                        }
                        catch (Com.Honeywell.Aidc.ScannerUnavailableException)
                        {
                            result.Code = Result.Codes.INTERNAL_ERROR;
                            result.Message = "Reader is not available.";
                        }
                    }
                }
                catch (Java.Lang.Exception ex)
                {
                    result.Code = Result.Codes.EXCEPTION;
                    result.Message = ex.Message;
                }
                catch (Exception ex)
                {
                    result.Code = Result.Codes.EXCEPTION;
                    result.Message = ex.Message;
                }
            }
            else
            {
                result.Code = Result.Codes.READER_ALREADY_OPENED;
                result.Message = "Reader was already opened.";
            }

            return result;
        }

        /// <summary>Closes the barcode reader.</summary>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public override async Task<Result> CloseAsync()
        {
            Logger.Debug("BarcodeReader", "CloseAsync entry");
            return await Task.Run(() =>
            {
                Result result = new Result(Result.Codes.SUCCESS, "Success.");

                lock (mProfileFixLock)
                {
                    if (mReaderOpened)
                    {
                        try
                        {
                            mAidcBarcodeReader.Close();

                            result = new Result(Result.Codes.SUCCESS, "Close completed.");
                        }
                        catch (Java.Lang.Exception ex)
                        {
                            result = new Result(Result.Codes.EXCEPTION, ex.Message);
                        }

                        if (result.Code == Result.Codes.SUCCESS)
                        {
                            mReaderOpened = false;

                            BarcodeReaderProfileHandler.Instance.LoadProfileOccurred -= LoadProfileOccurred;
                        }
                    }
                    else
                    {
                        result = new Result(Result.Codes.SUCCESS, "Reader already released.");
                    }
                }

                Logger.Info("BarcodeReader", "CloseAsync returns Code:" + result.Code + " Message:" + result.Message);

                return result;
            });
        }

        /// <summary>
        /// Sets a collection of decoder or symbology settings. The settings parameter
        /// contains a collection of key-value pairs where the key identifies the setting.
        /// <para>You may use <see cref="P:DevFromDownUnder.Honeywell.DataCollection.SettingKeys" /> to get the
        /// predefined setting keys. The setting value type may be any built-in C# types
        /// such as bool, int, string, etc. You may use <see cref="P:DevFromDownUnder.Honeywell.DataCollection.SettingValues" />
        /// to get the predefined values for certain settings. Please reference the API
        /// documentation of the <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingKeys" /> class for the
        /// expected setting value types.</para>
        /// <para>Note: This method may not return error result if the setting is not
        /// supported by the decoder or the setting value is not accepted by the decoder.</para>
        /// </summary>
        /// <param name="settings">A Dictionary object containing setting key-value pairs.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        /// <example>
        /// <code>
        /// using DevFromDownUnder.Honeywell.DataCollection.BarcodeReader;
        /// BarcodeReader mBarcodeReader = new BarcodeReader();
        /// BarcodeReader.Result result = await mBarcodeReader.OpenAsync();
        /// if (result.Code == BarcodeReader.Result.Codes.SUCCESS ||
        ///     result.Code == BarcodeReader.Result.Codes.READER_ALREADY_OPENED)
        /// {
        ///     Dictionary&lt;string, object&gt; settings = new Dictionary&lt;string, object&gt;();
        ///     settings.Add(mBarcodeReader.SettingKeys.Code39Enabled, true);
        ///     settings.Add(mBarcodeReader.SettingKeys.Code39CheckDigitMode,
        ///     mBarcodeReader.SettingValues.Code39CheckDigitMode_NoCheck);
        ///     result = await mBarcodeReader.SetAsync(settings);
        /// }
        /// </code>
        /// </example>
        /// <seealso cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingKeys" />
        /// <seealso cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues" />
        public override async Task<Result> SetAsync(Dictionary<string, object> settings)
        {
            Logger.Debug("BarcodeReader", "SetAsync entry");

            return await Task.Run(() =>
            {
                Result result = new Result(Result.Codes.SUCCESS, "Success");

                lock (mProfileFixLock)
                {
                    if (mReaderOpened)
                    {
                        try
                        {
                            var dictionary = new Dictionary<string, Java.Lang.Object>();
                            foreach (KeyValuePair<string, object> setting in settings)
                            {
                                try
                                {
                                    dictionary.Add(setting.Key, ObjectTypeHelper.ConvertSettingValueToJavaObject(setting.Value));
                                }
                                catch (ArgumentException ex)
                                {
                                    result = new Result(Result.Codes.INVALID_PARAMETER, ex.Message);
                                }
                            }

                            if (result.Code == Result.Codes.SUCCESS)
                            {
                                mAidcBarcodeReader.SetProperties(dictionary);

                                result = new Result(Result.Codes.SUCCESS, "Set method completed.");
                            }
                        }
                        catch (Java.Lang.Exception ex)
                        {
                            result = new Result(Result.Codes.EXCEPTION, ex.Message);
                        }
                        catch (Exception ex)
                        {
                            result = new Result(Result.Codes.EXCEPTION, ex.Message);
                        }
                    }
                    else
                    {
                        result = new Result(Result.Codes.NO_ACTIVE_CONNECTION, "No active scanner connection.");
                    }
                }

                return result;
            });
        }

        /// <summary>
        /// Starts or stops the software trigger. When the on parameter is true, it
        /// activates the aimer to start decoding barcodes.
        /// Note: Some readers may not support the software trigger.
        /// </summary>
        /// <param name="on">A Boolean value to indicate whether to start or
        /// stop the software trigger.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public override Task<Result> SoftwareTriggerAsync(bool on)
        {
            return Task.Run(() =>
            {
                Result result;

                lock (mProfileFixLock)
                {
                    if (mReaderOpened)
                    {
                        try
                        {
                            if (on)
                            {
                                mAidcBarcodeReader.SoftwareTrigger(false);
                                mAidcBarcodeReader.SoftwareTrigger(true);
                                result = new Result(Result.Codes.SUCCESS, "Software trigger on.");
                            }
                            else
                            {
                                mAidcBarcodeReader.SoftwareTrigger(false);
                                result = new Result(Result.Codes.SUCCESS, "Software trigger off.");
                            }
                        }
                        catch (Java.Lang.Exception ex)
                        {
                            result = new Result(Result.Codes.EXCEPTION, ex.Message);
                        }
                    }
                    else
                    {
                        result = new Result(Result.Codes.NO_ACTIVE_CONNECTION, "No active scanner connection.");
                    }

                    return result;
                }
            });
        }

        /// <summary>Enables or disables the barcode reader.</summary>
        /// <param name="enabled">A Boolean value to indicate whether to enable or
        /// disable the barcode reader.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public override Task<Result> EnableAsync(bool enabled)
        {
            return Task.Run(() =>
            {
                Result result;

                lock (mProfileFixLock)
                {
                    if (mReaderOpened)
                    {
                        try
                        {
                            if (enabled)
                            {
                                mAidcBarcodeReader.SetProperty("TRIG_CONTROL_MODE", "autoControl");
                                result = new Result(Result.Codes.SUCCESS, "Hardware trigger enabled.");
                            }
                            else
                            {
                                mAidcBarcodeReader.SetProperty("TRIG_CONTROL_MODE", "disable");
                                result = new Result(Result.Codes.SUCCESS, "Hardware trigger disabled.");
                            }
                        }
                        catch (Com.Honeywell.Aidc.UnsupportedPropertyException)
                        {
                            result = new Result(Result.Codes.INTERNAL_ERROR, "Failed to set trigger control mode.");
                        }
                        catch (Java.Lang.Exception ex)
                        {
                            result = new Result(Result.Codes.EXCEPTION, ex.Message);
                        }
                    }
                    else
                    {
                        result = new Result(Result.Codes.NO_ACTIVE_CONNECTION, "No active scanner connection.");
                    }

                    return result;
                }
            });
        }

        /// <summary>
        /// Gets a list of barcode readers that are currently connected.
        /// </summary>
        /// <param name="context">This is an optional parameter default to null.
        /// On Android platform, it will use Android.App.Application.Context if
        /// the parameter value is null. If the parameter is not null, then it
        /// needs to be a type of Android.Content.Context. It can
        /// be either an activity or application context.</param>
        /// <returns>A list of <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderInfo" /> objects representing
        /// barcode readers that are currently connected.</returns>
        public static async Task<IList<BarcodeReaderInfo>> GetConnectedBarcodeReaders(object context = null)
        {
            if (context == null)
            {
                context = Application.Context;
            }
            else if (!(context is Context))
            {
                throw new ArgumentException("Invalid context type, must be Android.Content.Context.", "context");
            }

            return await Task.Run(() =>
            {
                lock (mOpenLock)
                {
                    using BarcodeReaderManager barcodeReaderManager = BarcodeReaderManager.Create((Context)context);

                    barcodeReaderManager.Init();

                    return barcodeReaderManager.ListConnectedBarcodeDevices();
                }
            });
        }

        /// <summary>Releases the barcode reader resources.</summary>
        protected override void DisposeReader()
        {
            try
            {
                //No lock check here, we are disposing
                if (mReaderOpened)
                {
                    BarcodeReaderProfileHandler.Instance.LoadProfileOccurred -= LoadProfileOccurred;
                    mAidcBarcodeReader.Close();
                }
            }
            catch (Java.Lang.Exception ex)
            {
                Logger.Info("BarcodeReader", "Exception occurs in closing reader session, " + ex.Message);
            }
        }

        public async Task<Result> LoadProfileAsync(string profileName, bool fallbackToDefault = true)
        {
            return await Task.Run(() =>
            {
                Result result = default;

                lock (mProfileFixLock)
                {
                    if (mReaderOpened)
                    {
                        bool loaded = false;
                        try
                        {
                            loaded = mAidcBarcodeReader.LoadProfile(profileName);

                            if (loaded)
                            {
                                CurrentProfile = profileName;
                            }

                            if (!loaded && fallbackToDefault)
                            {
                                loaded = mAidcBarcodeReader.LoadProfile(DEFAULT_PROFILE);

                                if (loaded)
                                {
                                    CurrentProfile = DEFAULT_PROFILE;
                                }
                            }

                            IDictionary<string, Java.Lang.Object> properties = default;

                            //Get the settings from the loaded profile
                            if (loaded)
                            {
                                properties = CleanProperties(mAidcBarcodeReader.AllProperties);
                            }

                            //Ensure all other readers get reset
                            //We will handle our own reset for better error handling
                            //So we will unsubscribe and Open in the ResetReader will re-subscribe
                            BarcodeReaderProfileHandler.Instance.LoadProfileOccurred -= LoadProfileOccurred;
                            BarcodeReaderProfileHandler.Instance.ApplyFix(mScannerName, profileName, properties);

                            //Reset the reader as loadProfile is broken and kills readers
                            result = ResetReader();

                            //Set the properties from our profile if we loaded it
                            if (result.Code == Result.Codes.SUCCESS && properties != null)
                            {
                                mAidcBarcodeReader.SetProperties(properties);
                            }
                        }
                        catch (Java.Lang.Exception ex)
                        {
                            return new Result(Result.Codes.EXCEPTION, ex.Message);
                        }
                        catch (Exception ex)
                        {
                            return new Result(Result.Codes.EXCEPTION, ex.Message);
                        }
                    }
                    else
                    {
                        result = new Result(Result.Codes.NO_ACTIVE_CONNECTION, "Reader must be open.");
                    }
                }

                return result;
            });
        }

        #region LoadProfile issue fix functions

        private void LoadProfileOccurred(object sender, LoadProfileEventArgs e)
        {
            try
            {
                //Not sure if the reset is only needed for the same scanner or all
                //Will assume its same for now
                //If not, this if would get combind with the success if below instead
                if (e.ScannerName == mScannerName)
                {
                    lock (mProfileFixLock)
                    {
                        //Don't need to check if we have an open reader as we made it only
                        // subscribe and unsubscribe on open and close

                        //Reset the reader as loadProfile is broken and kills readers
                        var result = ResetReader();

                        //Set the properties if we are using the same profile and scanner
                        if (result?.Code == Result.Codes.SUCCESS && e.ProfileProperties != null && CurrentProfile == e.ProfileName)
                        {
                            mAidcBarcodeReader?.SetProperties(e.ProfileProperties);
                        }
                    }
                }
            }
            catch (Java.Lang.Exception) { }
            catch (Exception) { }
        }

        private Result CleanupPreviousReader()
        {
            try
            {
                //Might need to release manager device listener

                mAidcBarcodeReader?.RemoveBarcodeListener(mBarcodeEventHandler);
                mAidcBarcodeReader?.Release();

                if (mReaderOpened)
                {
                    mAidcBarcodeReader?.Close();
                    mReaderOpened = false;
                }

                mAidcBarcodeReader?.Dispose();
                mAidcBarcodeReader = null;

                return new Result(Result.Codes.SUCCESS, "Reader released.");
            }
            catch (Java.Lang.Exception ex)
            {
                return new Result(Result.Codes.EXCEPTION, ex.Message);
            }
            catch (Exception ex)
            {
                return new Result(Result.Codes.EXCEPTION, ex.Message);
            }
        }

        private Result ResetReader()
        {
            _ = CleanupPreviousReader();

            //Think we will just try re-opening even if release fails
            // we will be overriding so it will be disposed
            // it just may not close, which can at worst cause the open to fail
            return OpenReader(mScannerName, (Context)mContext);
        }

        private IDictionary<string, Java.Lang.Object> CleanProperties(IDictionary<string, Java.Lang.Object> properties)
        {
            //Apparentlly there is some issue with this property
            //We will just ignore it for now

            if (properties?.ContainsKey("DPR_WEDGE") ?? false)
            {
                properties?.Remove("DPR_WEDGE");
            }

            return properties;
        }

        #endregion LoadProfile issue fix functions

        /// <summary>
        /// Gets a list of properties.
        ///
        /// Will return empty Dictionary if barcode reader is not open
        /// </summary>
        /// <returns>Dictionary of barcode reader properties</returns>
        public Dictionary<string, object> GetProperties()
        {
            var result = new Dictionary<string, object>();

            lock (mProfileFixLock)
            {
                if (mReaderOpened)
                {
                    result = GetProperties(mAidcBarcodeReader);
                }
            }

            return result;
        }

        protected Dictionary<string, object> GetProperties(Com.Honeywell.Aidc.BarcodeReader reader)
        {
            var result = new Dictionary<string, object>();

            foreach (var pair in reader.AllProperties)
            {
                result.Add(pair.Key, ObjectTypeHelper.ConvertJavaObjectToSettingValue(pair.Value));
            }

            return result;
        }

        /// <summary>
        /// Gets a list of default properties.
        ///
        /// Will return empty Dictionary if barcode reader is not open.
        /// </summary>
        /// <returns>Dictionary of barcode reader properties</returns>
        public Dictionary<string, object> GetDefaultProperties()
        {
            var result = new Dictionary<string, object>();

            lock (mProfileFixLock)
            {
                if (mReaderOpened)
                {
                    result = GetDefaultProperties(mAidcBarcodeReader);
                }
            }

            return result;
        }

        protected Dictionary<string, object> GetDefaultProperties(Com.Honeywell.Aidc.BarcodeReader reader)
        {
            var result = new Dictionary<string, object>();

            foreach (var pair in reader.AllDefaultProperties)
            {
                result.Add(pair.Key, ObjectTypeHelper.ConvertJavaObjectToSettingValue(pair.Value));
            }

            return result;
        }

        /// <summary>
        /// Get a list of profile names setup in the device sanning settings.
        ///
        /// Will return empty list if barcode reader is not open.
        /// </summary>
        /// <returns>List of barcode reader profiles</returns>
        public IList<string> GetProfileNames()
        {
            lock (mProfileFixLock)
            {
                if (mReaderOpened)
                {
                    return mAidcBarcodeReader.ProfileNames;
                }
                else
                {
                    return new List<string>();
                }
            }
        }

        /// <summary>
        /// Determine if profile exists
        /// </summary>
        /// <param name="name">profile name</param>
        /// <returns>Returns if profile name exists</returns>
        public bool ProfileExists(string name)
        {
            lock (mProfileFixLock)
            {
                return mReaderOpened && (mAidcBarcodeReader.ProfileNames?.Contains(name) ?? false);
            }
        }

        /// <summary>
        /// Capture image from the scanner
        /// </summary>
        /// <returns>Captured image</returns>
        public Android.Graphics.Bitmap CaptureImage()
        {
            lock (mProfileFixLock)
            {
                //Doesn't appear to require it to be opened
                //However mAidcBarcodeReader will be null in this library if you don't open it
                if (mReaderOpened)
                {
                    return mAidcBarcodeReader.CaptureImage();
                }
                else
                {
                    return null;
                }
            }
        }
    }
}