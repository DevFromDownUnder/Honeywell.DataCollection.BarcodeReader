namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// This class provides information of a barcode reader device.
    /// </summary>
    public class BarcodeReaderInfo
    {
        /// <summary>
        /// The name uniquely identifies the scanner. This name can be used in
        /// the <see cref="M:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReader.#ctor(System.String,System.Object)" />
        /// constructor.
        /// </summary>
        public string ScannerName { get; private set; }

        /// <summary>The scan engine ID.</summary>
        public string ScannerID { get; internal set; }

        /// <summary>The friendly name of the scanner.</summary>
        public string ScanneFriendlyName { get; internal set; }

        internal BarcodeReaderInfo(string scannerName)
        {
            this.ScannerName = scannerName;
            this.ScannerID = string.Empty;
            this.ScanneFriendlyName = string.Empty;
        }
    }
}