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

        /// <summary>
        /// Gets a boolean value indicating whether the barcode reader is opened.
        /// </summary>
        public override bool IsReaderOpened
        {
            get
            {
                return this.mReaderOpened;
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
        public BarcodeReader(object context = null)
          : base(context)
        {
            if (context == null)
                this.mContext = (object)Application.Context;
            else if (!(context is Context))
                throw new ArgumentException("Invalid context type, must be Android.Content.Context.", "context");
            this.mScannerName = "dcs.scanner.imager";
            this.SetBarcodeDeviceListener(this.mContext);
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
        public BarcodeReader(string scannerName, object context = null)
          : base(scannerName, context)
        {
            if (context == null)
                this.mContext = (object)Application.Context;
            else if (!(context is Context))
                throw new ArgumentException("Invalid context type, must be Android.Content.Context.", "context");
            if (scannerName == null)
                this.mScannerName = "dcs.scanner.imager";
            this.SetBarcodeDeviceListener(this.mContext);
        }

        /// <summary>
        /// Sets the AddBarcodeDeviceListener for device connection status.
        /// </summary>
        /// <param name="context">This parameter needs to be a type of Android.Content.Context.
        /// It can be an activity or application context.</param>
        private void SetBarcodeDeviceListener(object context)
        {
            if (sBarcodeDeviceEventHandler != null)
                return;
            Task.Run((Action)(() =>
           {
               BarcodeReaderManager barcodeReaderManager = BarcodeReaderManager.Create((Context)context);
               if (this.mAidcManager == null)
                   this.mAidcManager = barcodeReaderManager.Init();
               sBarcodeDeviceEventHandler = new BarcodeDeviceEventHandler(this);
               this.mAidcManager.AddBarcodeDeviceListener((Com.Honeywell.Aidc.AidcManager.IBarcodeDeviceListener)sBarcodeDeviceEventHandler);
           }));
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
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public override async Task<BarcodeReaderBase.Result> OpenAsync()
        {
            BarcodeReader barcodeReader = this;
            Logger.Debug("BarcodeReader", "OpenAsync entry");
            BarcodeReaderBase.Result result = await Task.Run<BarcodeReaderBase.Result>(() => OpenReader(mScannerName, (Context)mContext));
            Logger.Info("BarcodeReader", "OpenAsync returns Code:" + (object)result.Code + " Message:" + result.Message);
            return result;
        }

        private BarcodeReaderBase.Result OpenReader(string scannerName, Context context)
        {
            BarcodeReaderBase.Result result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.SUCCESS, "Reader successfully claimed.");
            if (!this.mReaderOpened)
            {
                try
                {
                    if (this.mAidcBarcodeReader == null)
                    {
                        this.mAidcManager = BarcodeReaderManager.Create(context).Init();
                        this.mAidcBarcodeReader = this.mAidcManager.CreateBarcodeReader(scannerName);
                        try
                        {
                            this.mAidcBarcodeReader.SetProperty("TRIG_CONTROL_MODE", "autoControl");
                        }
                        catch (Com.Honeywell.Aidc.UnsupportedPropertyException)
                        {
                            result.Code = BarcodeReaderBase.Result.Codes.INTERNAL_ERROR;
                            result.Message = "Failed to set trigger control mode.";
                        }
                        if (result.Code == BarcodeReaderBase.Result.Codes.SUCCESS)
                        {
                            this.mBarcodeEventHandler = new BarcodeEventHandler(this);
                            this.mAidcBarcodeReader.AddBarcodeListener((Com.Honeywell.Aidc.BarcodeReader.IBarcodeListener)this.mBarcodeEventHandler);
                        }
                    }
                    if (result.Code == BarcodeReaderBase.Result.Codes.SUCCESS)
                    {
                        try
                        {
                            this.mAidcBarcodeReader.Claim();
                            this.mReaderOpened = true;
                        }
                        catch (Com.Honeywell.Aidc.ScannerUnavailableException)
                        {
                            result.Code = BarcodeReaderBase.Result.Codes.INTERNAL_ERROR;
                            result.Message = "Reader is not available.";
                        }
                    }
                }
                catch (Java.Lang.Exception ex)
                {
                    result.Code = BarcodeReaderBase.Result.Codes.EXCEPTION;
                    result.Message = ex.Message;
                }
            }
            else
            {
                result.Code = BarcodeReaderBase.Result.Codes.READER_ALREADY_OPENED;
                result.Message = "Reader was already opened.";
            }
            return result;
        }

        /// <summary>Closes the barcode reader.</summary>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public override async Task<BarcodeReaderBase.Result> CloseAsync()
        {
            BarcodeReader barcodeReader = this;
            Logger.Debug("BarcodeReader", "CloseAsync entry");
            BarcodeReaderBase.Result result;
            if (barcodeReader.mReaderOpened)
            {
                result = await Task.Run<BarcodeReaderBase.Result>((Func<BarcodeReaderBase.Result>)(() =>
                {
                    try
                    {
                        this.mAidcBarcodeReader.Close();
                    }
                    catch (Java.Lang.Exception ex)
                    {
                        return new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.EXCEPTION, ex.Message);
                    }
                    return new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.SUCCESS, "Set method completed.");
                }));

                if (result.Code == BarcodeReaderBase.Result.Codes.SUCCESS)
                    barcodeReader.mReaderOpened = false;
            }
            else
                result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.SUCCESS, "Reader already released.");
            Logger.Info("BarcodeReader", "CloseAsync returns Code:" + (object)result.Code + " Message:" + result.Message);
            return result;
        }

        /// <summary>
        /// Sets a collection of decoder or symbology settings. The settings parameter
        /// contains a collection of key-value pairs where the key identifies the setting.
        /// <para>You may use <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingKeys" /> to get the
        /// predefined setting keys. The setting value type may be any built-in C# types
        /// such as bool, int, string, etc. You may use <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" />
        /// to get the predefined values for certain settings. Please reference the API
        /// documentation of the <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingKeys" /> class for the
        /// expected setting value types.</para>
        /// <para>Note: This method may not return error result if the setting is not
        /// supported by the decoder or the setting value is not accepted by the decoder.</para>
        /// </summary>
        /// <param name="settings">A Dictionary object containing setting key-value pairs.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.Result" /> object containing the success or
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
        public override async Task<BarcodeReaderBase.Result> SetAsync(Dictionary<string, object> settings)
        {
            BarcodeReader barcodeReader = this;
            Logger.Debug("BarcodeReader", "SetAsync entry");
            BarcodeReaderBase.Result result;
            if (barcodeReader.mReaderOpened)
                result = await Task.Run<BarcodeReaderBase.Result>((Func<BarcodeReaderBase.Result>)(() =>
               {
                   try
                   {
                       Dictionary<string, Java.Lang.Object> dictionary = new Dictionary<string, Java.Lang.Object>();
                       foreach (KeyValuePair<string, object> setting in settings)
                       {
                           try
                           {
                               dictionary.Add(setting.Key, ObjectTypeHelper.ConvertSettingValueToJavaObject(setting.Value));
                           }
                           catch (ArgumentException ex)
                           {
                               return new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.INVALID_PARAMETER, ex.Message);
                           }
                       }
                       this.mAidcBarcodeReader.SetProperties((IDictionary<string, Java.Lang.Object>)dictionary);
                   }
                   catch (Java.Lang.Exception ex)
                   {
                       return new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.EXCEPTION, ex.Message);
                   }
                   return new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.SUCCESS, "Set method completed.");
               }));
            else
                result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.NO_ACTIVE_CONNECTION, "No active scanner connection.");
            return result;
        }

        /// <summary>
        /// Starts or stops the software trigger. When the on parameter is true, it
        /// activates the aimer to start decoding barcodes.
        /// Note: Some readers may not support the software trigger.
        /// </summary>
        /// <param name="on">A Boolean value to indicate whether to start or
        /// stop the software trigger.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public override Task<BarcodeReaderBase.Result> SoftwareTriggerAsync(bool on)
        {
            BarcodeReaderBase.Result result;
            if (this.mReaderOpened)
            {
                try
                {
                    if (on)
                    {
                        this.mAidcBarcodeReader.SoftwareTrigger(false);
                        this.mAidcBarcodeReader.SoftwareTrigger(true);
                        result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.SUCCESS, "Software trigger on.");
                    }
                    else
                    {
                        this.mAidcBarcodeReader.SoftwareTrigger(false);
                        result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.SUCCESS, "Software trigger off.");
                    }
                }
                catch (Java.Lang.Exception ex)
                {
                    result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.EXCEPTION, ex.Message);
                }
            }
            else
                result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.NO_ACTIVE_CONNECTION, "No active scanner connection.");
            return Task.FromResult<BarcodeReaderBase.Result>(result);
        }

        /// <summary>Enables or disables the barcode reader.</summary>
        /// <param name="enabled">A Boolean value to indicate whether to enable or
        /// disable the barcode reader.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public override Task<BarcodeReaderBase.Result> EnableAsync(bool enabled)
        {
            BarcodeReaderBase.Result result;
            if (this.mReaderOpened)
            {
                try
                {
                    if (enabled)
                    {
                        this.mAidcBarcodeReader.SetProperty("TRIG_CONTROL_MODE", "autoControl");
                        result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.SUCCESS, "Hardware trigger enabled.");
                    }
                    else
                    {
                        this.mAidcBarcodeReader.SetProperty("TRIG_CONTROL_MODE", "disable");
                        result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.SUCCESS, "Hardware trigger disabled.");
                    }
                }
                catch (Com.Honeywell.Aidc.UnsupportedPropertyException)
                {
                    result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.INTERNAL_ERROR, "Failed to set trigger control mode.");
                }
                catch (Java.Lang.Exception ex)
                {
                    result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.EXCEPTION, ex.Message);
                }
            }
            else
                result = new BarcodeReaderBase.Result(BarcodeReaderBase.Result.Codes.NO_ACTIVE_CONNECTION, "No active scanner connection.");
            return Task.FromResult<BarcodeReaderBase.Result>(result);
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
                context = (object)Application.Context;
            else if (!(context is Context))
                throw new ArgumentException("Invalid context type, must be Android.Content.Context.", "context");
            return await Task.Run<IList<BarcodeReaderInfo>>((Func<IList<BarcodeReaderInfo>>)(() =>
           {
               BarcodeReaderManager barcodeReaderManager = BarcodeReaderManager.Create((Context)context);
               barcodeReaderManager.Init();
               return barcodeReaderManager.ListConnectedBarcodeDevices();
           }));
        }

        /// <summary>Releases the barcode reader resources.</summary>
        protected override void DisposeReader()
        {
            try
            {
                this.mAidcBarcodeReader.Close();
            }
            catch (Java.Lang.Exception ex)
            {
                Logger.Info("BarcodeReader", "Exception occurs in closing reader session, " + ex.Message);
            }
        }
    }
}