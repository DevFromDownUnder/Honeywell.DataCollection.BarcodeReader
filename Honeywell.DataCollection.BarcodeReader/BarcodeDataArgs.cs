using System;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// Provides data for the <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.BarcodeDataReady" /> event.
    /// </summary>
    public class BarcodeDataArgs : EventArgs
    {
        /// <summary>The scanned barcode data.</summary>
        public string Data { get; }

        /// <summary>
        /// The symbology type of the scanned barcode. The symbology types are
        /// defined in the <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeSymbologies" /> class.
        /// </summary>
        /// <seealso cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeSymbologies" />
        public uint SymbologyType { get; }

        /// <summary>
        /// The string representation of <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeDataArgs.SymbologyType" />.
        /// </summary>
        public string SymbologyName { get; }

        /// <summary>The time when the barcode was scanned.</summary>
        public DateTime TimeStamp { get; }

        /// <summary>
        /// Creates a BarcodeDataArgs object containing the specified info.
        /// </summary>
        /// <param name="data">The scanned barcode data.</param>
        /// <param name="symbType">The symbology type of the scanned barcode.</param>
        /// <param name="symbName">The string representation of symbType.</param>
        /// <param name="time">The time when the barcode was scanned.</param>
        internal BarcodeDataArgs(string data, uint symbType, string symbName, DateTime time)
        {
            Data = data;
            SymbologyType = symbType;
            SymbologyName = symbName;
            TimeStamp = time;
        }
    }
}