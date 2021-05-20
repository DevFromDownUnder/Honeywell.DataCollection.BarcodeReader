using Android.Runtime;
using Java.Util;
using System;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader.BarcodeReader
{
    internal class BarcodeDeviceEventHandler : Java.Lang.Object, Com.Honeywell.Aidc.AidcManager.IBarcodeDeviceListener, IEventListener, IJavaObject, IDisposable
    {
        private readonly BarcodeReader mBarcodeReader;

        /// <summary>
        /// Create a BarcodeDeviceEventHandler object with the specified handler.
        /// </summary>
        /// <param name="source">The AidcManager object that originates the event.</param>
        internal BarcodeDeviceEventHandler(BarcodeReader source) : base()
        {
            this.mBarcodeReader = source;
        }

        /// <summary>
        /// Implements the IBarcodeListener interface. Invoked when a device is connected
        /// </summary>
        /// <param name="e">Device information and connection status.</param>
        public void OnBarcodeDeviceConnectionEvent(Com.Honeywell.Aidc.BarcodeDeviceConnectionEvent e)
        {
            Logger.Info("BarcodeReader", "Device Connection status: " + e.ConnectionStatus.ToString() + ", Scanner Name = " + e.BarcodeReaderInfo.Name);
            if (!this.mBarcodeReader.HasBarcodeDeviceSubscriber)
                return;
            this.mBarcodeReader.OnConnectedStateChanged(new ConnectionStateArgs(e.BarcodeReaderInfo.ScannerId, e.BarcodeReaderInfo.Name, e.BarcodeReaderInfo.FriendlyName, e.ConnectionStatus));
        }
    }
}