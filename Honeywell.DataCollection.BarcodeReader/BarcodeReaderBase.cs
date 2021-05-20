﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// This abstract class defines common barcode reader interfaces and
    /// data types.
    /// </summary>
    public abstract class BarcodeReaderBase : IDisposable, IBarcodeReader
    {
        /// <summary>
        /// An instance of <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderSettingKeys" /> which a subclass may override.
        /// </summary>
        protected BarcodeReaderSettingKeys mSettingKeys = new BarcodeReaderSettingKeys();

        /// <summary>
        /// An instance of <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderSettingValues" /> which a subclass may override.
        /// </summary>
        protected BarcodeReaderSettingValues mSettingValues = new BarcodeReaderSettingValues();

        /// <summary>A string containing the name of the barcode reader.</summary>
        protected string mScannerName;

        /// <summary>An object specifying the platform specific context.</summary>
        protected object mContext;

        private bool disposedValue;

        /// <summary>
        /// Gets a boolean value indicating whether the barcode reader is opened.
        /// </summary>
        public abstract bool IsReaderOpened { get; }

        /// <summary>
        /// Gets the associated <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderSettingKeys" /> object that
        /// can be used to get the setting key for a specific setting.
        /// </summary>
        /// <seealso cref="M:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.SetAsync(System.Collections.Generic.Dictionary{System.String,System.Object})" />
        public virtual BarcodeReaderSettingKeys SettingKeys
        {
            get
            {
                return this.mSettingKeys;
            }
        }

        /// <summary>
        /// Gets the associated <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderSettingValues" /> object that
        /// can be used to get predefined setting values for certain settings.
        /// </summary>
        /// <seealso cref="M:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.SetAsync(System.Collections.Generic.Dictionary{System.String,System.Object})" />
        public virtual BarcodeReaderSettingValues SettingValues
        {
            get
            {
                return this.mSettingValues;
            }
        }

        /// <summary>
        /// Returns a boolean value to indicate whether there is a subscriber
        /// for the <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.BarcodeDataReady" /> event.
        /// </summary>
        internal bool HasBarcodeDataReadySubscriber
        {
            get
            {
                return this.BarcodeDataReady != null;
            }
        }

        /// <summary>
        /// Returns a boolean value to indicate whether there is a subscriber
        /// for the <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.ConnectionStateChanged" /> event.
        /// </summary>
        internal bool HasBarcodeDeviceSubscriber
        {
            get
            {
                return this.ConnectionStateChanged != null;
            }
        }

        /// <summary>Occurs when a barcode is successfully read.</summary>
        public event EventHandler<BarcodeDataArgs> BarcodeDataReady;

        /// <summary>Occurs when the reader's connection state changes.</summary>
        public event EventHandler<ConnectionStateArgs> ConnectionStateChanged;

        /// <summary>
        /// Create a BarcodeReader object for accessing the internal scanner.
        /// </summary>
        /// <param name="context">This parameter is only required on the Android
        /// be platform. It needs to be a type of Android.Content.Context. It can
        /// an activity or application context.</param>
        protected BarcodeReaderBase(object context = null)
        {
            this.mScannerName = (string)null;
            this.mContext = context;
        }

        /// <summary>
        /// Create a BarcodeReader object for accessing the specified scanner.
        /// </summary>
        /// <param name="scannerName">A string to identify the scanner that this
        /// object represents and operates on.</param>
        /// <param name="context">This parameter is only required on the Android
        /// platform. It needs to be a type of Android.Content.Context. It can
        /// be an activity or application context.</param>
        protected BarcodeReaderBase(string scannerName, object context = null)
        {
            this.mScannerName = scannerName;
            this.mContext = context;
        }

        /// <summary>BarcodeReaderBase class destructor.</summary>
        ~BarcodeReaderBase()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Opens the barcode reader specified in the constructor.
        /// </summary>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public abstract Task<BarcodeReaderBase.Result> OpenAsync();

        /// <summary>Closes the barcode reader.</summary>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public abstract Task<BarcodeReaderBase.Result> CloseAsync();

        /// <summary>Sets a collection of decoder or symbology settings.</summary>
        /// <param name="settings">A Dictionary object containing setting key-value pairs.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public abstract Task<BarcodeReaderBase.Result> SetAsync(Dictionary<string, object> settings);

        /// <summary>
        /// Starts or stops the software trigger. When the on parameter is true, it
        /// activates the aimer to start decoding barcodes.
        /// Note: Some readers may not support the software trigger.
        /// </summary>
        /// <param name="on">A Boolean value to indicate whether to start or
        /// stop the software trigger.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public abstract Task<BarcodeReaderBase.Result> SoftwareTriggerAsync(bool on);

        /// <summary>Enables or disables the barcode reader.</summary>
        /// <param name="enabled">A Boolean value to indicate whether to enable or
        /// disable the barcode reader.</param>
        /// <returns>A <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.Result" /> object containing the success or
        /// failure result of the operation.</returns>
        public abstract Task<BarcodeReaderBase.Result> EnableAsync(bool enabled);

        /// <summary>Releases the barcode reader resources.</summary>
        protected abstract void DisposeReader();

        /// <summary>
        /// Fires the <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.BarcodeDataReady" /> event.
        /// </summary>
        /// <param name="e"></param>
        internal virtual void OnBarcodeDataRead(BarcodeDataArgs e)
        {
            // ISSUE: reference to a compiler-generated field
            EventHandler<BarcodeDataArgs> barcodeDataReady = this.BarcodeDataReady;
            if (barcodeDataReady == null)
                return;
            barcodeDataReady((object)this, e);
        }

        /// <summary>
        /// Fires the <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.ConnectionStateChanged" /> event.
        /// </summary>
        /// <param name="e"></param>
        internal virtual void OnConnectedStateChanged(ConnectionStateArgs e)
        {
            // ISSUE: reference to a compiler-generated field
            EventHandler<ConnectionStateArgs> connectionStateChanged = this.ConnectionStateChanged;
            if (connectionStateChanged == null)
                return;
            connectionStateChanged((object)this, e);
        }

        /// <summary>Releases resources.</summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposedValue)
                return;
            this.DisposeReader();
            this.disposedValue = true;
        }

        /// <summary>
        /// Implements the IDisposable interface to release scanning resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize((object)this);
        }

        /// <summary>Contains the method execution result.</summary>
        public class Result
        {
            private int mCode;
            private string mMessage;

            /// <summary>Common facility code for BarcodeReader.</summary>
            internal const int BARCODE_READER_FACILITY = 2411;

            /// <summary>
            /// An integer status code. 0 (zero) indicates a successful status
            /// and all other values indicate failure.
            /// </summary>
            public int Code
            {
                get
                {
                    return this.mCode;
                }
                internal set
                {
                    this.mCode = value;
                }
            }

            /// <summary>
            /// A string containing a human-readable message for the operation status.
            /// </summary>
            public string Message
            {
                get
                {
                    return this.mMessage;
                }
                internal set
                {
                    this.mMessage = value;
                }
            }

            /// <summary>
            /// Constructs a Result object with the specified status code and
            /// message.
            /// </summary>
            /// <param name="code">An integer status code.</param>
            /// <param name="message">A string containing a human-readable
            /// message for the operation status.</param>
            internal Result(int code, string message)
            {
                this.mCode = code;
                this.mMessage = message;
            }

            /// <summary>
            /// Constructs a Result object with the specified facility code,
            /// error code and message.
            /// </summary>
            /// <param name="facility">An integer value (0 - 0xFFFF) that
            /// identifies a specific facility originating the error.</param>
            /// <param name="error">An integer error code (0 - 0xFFFF).</param>
            /// <param name="message">A string containing a human-readable
            /// message for the operation status.</param>
            internal Result(int facility, int error, string message)
            {
                this.mCode = BarcodeReaderBase.Result.FormatCode(facility, error);
                this.mMessage = message;
            }

            internal static int FormatCode(int facility, int error)
            {
                int num = 0;
                if (error != 0 && ((long)error & 4294901760L) == 0L)
                    num = int.MinValue | facility << 16 | error;
                return num;
            }

            /// <summary>
            /// Defines the common status codes returned in the
            /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.Result" /> object.
            /// </summary>
            public class Codes
            {
                /// <summary>Successful status.</summary>
                public static readonly int SUCCESS = 0;

                /// <summary>Unexpected exception</summary>
                public static readonly int EXCEPTION = BarcodeReaderBase.Result.FormatCode(2411, 1064);

                /// <summary>Invalid parameter.</summary>
                public static readonly int INVALID_PARAMETER = BarcodeReaderBase.Result.FormatCode(2411, 87);

                /// <summary>Internal error.</summary>
                public static readonly int INTERNAL_ERROR = BarcodeReaderBase.Result.FormatCode(2411, 1359);

                /// <summary>The barcode reader was already opened.</summary>
                public static readonly int READER_ALREADY_OPENED = BarcodeReaderBase.Result.FormatCode(2411, 2402);

                /// <summary>The feature is not supported.</summary>
                public static readonly int FEATURE_NOT_SUPPORTED = BarcodeReaderBase.Result.FormatCode(2411, 50);

                /// <summary>No active scanner connection.</summary>
                public static readonly int NO_ACTIVE_CONNECTION = BarcodeReaderBase.Result.FormatCode(2411, 1229);

                internal Codes()
                {
                }
            }
        }
    }
}