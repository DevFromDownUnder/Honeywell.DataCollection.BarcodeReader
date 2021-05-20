using Android.Content;
using Android.Runtime;
using Com.Honeywell.Aidc;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Honeywell.AIDC.CrossPlatform
{
    /// <summary>
    /// Initiates the connection to the Data Collection Service via the Java
    /// AidcManager class. The service connection only needs to be done once.
    /// </summary>
    internal class BarcodeReaderManager : Java.Lang.Object, AidcManager.ICreatedCallback, IJavaObject, IDisposable
    {
        private static BarcodeReaderManager sInstance = (BarcodeReaderManager)null;
        private static AutoResetEvent sServiceConnectedEvent = new AutoResetEvent(false);

        /// <summary>
        /// An application only needs one instance of AidcManager; therefore,
        /// it is declared as static. It can be used to create multiple
        /// instances of the Java BarcodeReader objects.
        /// </summary>
        private static AidcManager sAidcManager = (AidcManager)null;

        private Context mAppContext;

        private BarcodeReaderManager(Context context) : base()
        {
            if (context == null)
                throw new ArgumentNullException();
            this.mAppContext = context.ApplicationContext;
        }

        /// <summary>
        /// Returns an instance of the BarcodeReaderManager object.
        /// Note: The context parameter is only used the first time this method
        /// is called to create the BarcodeReaderManager object. The subsequent
        /// calls will simply return the existing BarcodeReaderManager object.
        /// It will get the application context from the context parameter.
        /// Even if this method is called from different Activity classes,
        /// their application context is the same.
        /// </summary>
        /// <param name="context">An activity or application context.</param>
        /// <returns></returns>
        internal static BarcodeReaderManager Create(Context context)
        {
            if (BarcodeReaderManager.sInstance == null)
                BarcodeReaderManager.sInstance = new BarcodeReaderManager(context);
            return BarcodeReaderManager.sInstance;
        }

        /// <summary>
        /// This method initiates the connection to the Data Collection Service
        /// by creating an AidcManager object. The AidcManager object is returned
        /// so it can be used to create the Java BarcodeReader objects.
        /// </summary>
        /// <returns>A Java AidcManager object.</returns>
        internal AidcManager Init()
        {
            if (BarcodeReaderManager.sAidcManager == null)
            {
                lock (this.mAppContext)
                {
                    try
                    {
                        Logger.Debug("BarcodeReader", "Creating AidcManager");
                        AidcManager.Create(this.mAppContext, (AidcManager.ICreatedCallback)this);
                        BarcodeReaderManager.sServiceConnectedEvent.WaitOne();
                    }
                    catch (Java.Lang.Exception ex)
                    {
                        Logger.Error("BarcodeReader", "Exception in creating AidcManager, " + ex.Message);
                    }
                }
            }
            return BarcodeReaderManager.sAidcManager;
        }

        void AidcManager.ICreatedCallback.OnCreated(AidcManager aidcManager)
        {
            Logger.Debug("BarcodeReader", "AidcManager OnCreated callback");
            BarcodeReaderManager.sAidcManager = aidcManager;
            BarcodeReaderManager.sServiceConnectedEvent.Set();
        }

        internal IList<BarcodeReaderInfo> ListConnectedBarcodeDevices()
        {
            List<BarcodeReaderInfo> barcodeReaderInfoList = new List<BarcodeReaderInfo>();
            if (BarcodeReaderManager.sAidcManager != null)
            {
                foreach (Com.Honeywell.Aidc.BarcodeReaderInfo connectedBarcodeDevice in (IEnumerable<Com.Honeywell.Aidc.BarcodeReaderInfo>)BarcodeReaderManager.sAidcManager.ListConnectedBarcodeDevices())
                    barcodeReaderInfoList.Add(new BarcodeReaderInfo(connectedBarcodeDevice.Name));
            }
            return (IList<BarcodeReaderInfo>)barcodeReaderInfoList;
        }
    }
}