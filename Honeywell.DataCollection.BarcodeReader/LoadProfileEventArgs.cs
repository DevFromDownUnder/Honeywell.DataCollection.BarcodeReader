using System;
using System.Collections.Generic;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    internal class LoadProfileEventArgs : EventArgs
    {
        public string ScannerName { get; }

        public string ProfileName { get; }

        public IDictionary<string, Java.Lang.Object> ProfileProperties { get; }

        public LoadProfileEventArgs(string scannerName, string profileName, IDictionary<string, Java.Lang.Object> properties)
        {
            ScannerName = scannerName;
            ProfileName = profileName;
            ProfileProperties = properties;
        }
    }
}