using System;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// Provides status for the <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.ConnectionStateChanged" /> event.
    /// </summary>
    public class ConnectionStateArgs : EventArgs
    {
        /// <summary>
        /// An object that contains the reader information when the reader's connection state changed.
        /// </summary>
        public BarcodeReaderInfo BarcodeReaderInfo;

        /// <summary>Gets the current connection state.</summary>
        public ConnectionStateArgs.ConnectionStates State { get; private set; }

        /// <summary>
        /// <param name="Id">Device Id.</param>
        /// <param name="name">Device name.</param>
        /// <param name="friendlyName">Device frendly name.</param>
        /// <param name="connectionState">The current connection state.</param>
        /// </summary>
        internal ConnectionStateArgs(string Id, string name, string friendlyName, int connectionState)
        {
            BarcodeReaderInfo = new BarcodeReaderInfo(name)
            {
                ScannerID = Id,
                ScanneFriendlyName = friendlyName
            };

            State = (connectionState == 0) ? ConnectionStates.DISCONNECTED : ConnectionStates.CONNECTED;
        }

        /// <summary>Define the constant values for the connection states.</summary>
        public enum ConnectionStates
        {
            CONNECTED,
            DISCONNECTED,
        }
    }
}