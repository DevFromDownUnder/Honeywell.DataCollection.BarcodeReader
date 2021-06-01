using System;
using System.Collections.Generic;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    internal class BarcodeReaderProfileHandler
    {
        public event EventHandler<LoadProfileEventArgs> LoadProfileOccurred;

        private static readonly BarcodeReaderProfileHandler instance = new BarcodeReaderProfileHandler();

        static BarcodeReaderProfileHandler()
        {
        }

        private BarcodeReaderProfileHandler()
        {
        }

        public static BarcodeReaderProfileHandler Instance => instance;

        public void ApplyFix(string scannerName, string profileName, IDictionary<string, Java.Lang.Object> properties)
        {
            LoadProfileOccurred?.Invoke(this, new LoadProfileEventArgs(scannerName, profileName, properties));
        }
    }
}