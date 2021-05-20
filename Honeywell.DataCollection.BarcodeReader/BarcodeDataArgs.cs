using System;

namespace Honeywell.AIDC.CrossPlatform
{
    /// <summary>
    /// Provides data for the <see cref="E:Honeywell.AIDC.CrossPlatform.BarcodeReaderBase.BarcodeDataReady" /> event.
    /// </summary>
    public class BarcodeDataArgs : EventArgs
    {
        private string data;
        private uint symbType;
        private string symbName;
        private DateTime timestamp;

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
        /// defined in the <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeSymbologies" /> class.
        /// </summary>
        /// <seealso cref="T:Honeywell.AIDC.CrossPlatform.BarcodeSymbologies" />
        public uint SymbologyType
        {
            get
            {
                return this.symbType;
            }
        }

        /// <summary>
        /// The string representation of <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeDataArgs.SymbologyType" />.
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