using Android.Runtime;
using Java.Util;
using System;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    internal class BarcodeEventHandler : Java.Lang.Object, Com.Honeywell.Aidc.BarcodeReader.IBarcodeListener, IEventListener, IJavaObject, IDisposable
    {
        private readonly BarcodeReader mBarcodeReader;

        /// <summary>
        /// Create a BarcodeReaderEventHandler object with the specified handler.
        /// </summary>
        /// <param name="source">The BarcodeReader object that originates the event.</param>
        internal BarcodeEventHandler(BarcodeReader source) : base()
        {
            mBarcodeReader = source;
        }

        /// <summary>
        /// Implements the IBarcodeListener interface. Invoked when a barcode
        /// is read.
        /// </summary>
        /// <param name="e"></param>
        public void OnBarcodeEvent(Com.Honeywell.Aidc.BarcodeReadEvent e)
        {
            Logger.Info("BarcodeReader", "Received barcode data:" + e.BarcodeData + " CodeId:" + e.CodeId + " AimId:" + e.AimId);

            if (!mBarcodeReader.HasBarcodeDataReadySubscriber)
            {
                return;
            }

            var symbologyMap = BarcodeSymbologies.GetSymbologyMap(e.CodeId, e.AimId[1..]);

            Logger.Info("BarcodeReader", "Symbology ID:" + symbologyMap.id + " Honeywell ID:" + symbologyMap.honeywellId + " aimId:" + symbologyMap.aimId + " Name:" + symbologyMap.name);

            mBarcodeReader.OnBarcodeDataRead(new BarcodeDataArgs(e.BarcodeData, symbologyMap.id, symbologyMap.name, DateTime.Now));
        }

        /// <summary>Implements the IBarcodeListener interface.</summary>
        /// <param name="e"></param>
        public void OnFailureEvent(Com.Honeywell.Aidc.BarcodeFailureEvent e)
        {
        }
    }
}