using System;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// Provides data for the <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReaderBase.BarcodeDataReady" /> event.
    /// </summary>
    public class BarcodeDataArgs : EventArgs
    {
        private readonly string data;
        private readonly uint symbType;
        private readonly string symbName;
        private readonly DateTime timestamp;

        /// <summary>The scanned barcode data.</summary>
        public string Data
        {
            get
            {
                return this.data;
            }
        }

        /// <summary>
        /// The symbology type of the scanned barcode. The symbology types are
        /// defined in the <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeSymbologies" /> class.
        /// </summary>
        /// <seealso cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeSymbologies" />
        public uint SymbologyType
        {
            get
            {
                return this.symbType;
            }
        }

        /// <summary>
        /// The string representation of <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeDataArgs.SymbologyType" />.
        /// </summary>
        public string SymbologyName
        {
            get
            {
                return this.symbName;
            }
        }

        /// <summary>The time when the barcode was scanned.</summary>
        public DateTime TimeStamp
        {
            get
            {
                return this.timestamp;
            }
        }

        /// <summary>
        /// Creates a BarcodeDataArgs object containing the specified info.
        /// </summary>
        /// <param name="data">The scanned barcode data.</param>
        /// <param name="symbType">The symbology type of the scanned barcode.</param>
        /// <param name="symbName">The string representation of symbType.</param>
        /// <param name="time">The time when the barcode was scanned.</param>
        internal BarcodeDataArgs(string data, uint symbType, string symbName, DateTime time)
        {
            this.data = data;
            this.symbType = symbType;
            this.symbName = symbName;
            this.timestamp = time;
        }
    }
}