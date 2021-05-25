using Android.Content;
using Android.Runtime;
using System;
using System.Threading.Tasks;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// Initiates the connection to the Data Collection Service via the Java
    /// AidcManager class. The service connection only needs to be done once.
    /// </summary>
    internal class BarcodeReaderManagerProfile : Java.Lang.Object, Com.Honeywell.Aidc.AidcManager.ICreatedCallback, IJavaObject, IDisposable
    {
        private static Com.Honeywell.Aidc.AidcManager mManager;
        private static BarcodeReaderManagerProfile mInstance;
        private Context mContext;

        private static TaskCompletionSource<Com.Honeywell.Aidc.AidcManager> CompletionSource;

        internal BarcodeReaderManagerProfile(Context context)
        {
            mContext = context;
        }

        public void OnCreated(Com.Honeywell.Aidc.AidcManager p0)
        {
            mManager = p0;

            CompletionSource.TrySetResult(p0);
        }

        public static BarcodeReaderManagerProfile GetInstance(Context context)
        {
            if (mInstance == null)
            {
                mInstance = new BarcodeReaderManagerProfile(context);
            }

            return mInstance;
        }


        public async Task<Com.Honeywell.Aidc.AidcManager> GetManager()
        {
            if (mManager == null)
            {

                using (new TimedLock().Lock(TimeSpan.FromSeconds(5)))
                {
                    try
                    {
                        CompletionSource = new TaskCompletionSource<Com.Honeywell.Aidc.AidcManager>();

                        Com.Honeywell.Aidc.AidcManager.Create(mContext, this);

                        return await CompletionSource.Task;
                    }
                    catch (Java.Lang.Exception ex)
                    {
                        Logger.Error("BarcodeReader", "Exception in creating ProfileAidcManager, " + ex.Message);
                    }
                }
            }

            return mManager;
        }
    }
}