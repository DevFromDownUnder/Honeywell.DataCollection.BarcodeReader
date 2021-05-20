using Android.Util;

namespace Honeywell.AIDC.CrossPlatform
{
    internal class Logger
    {
        internal static void Debug(string tag, string message)
        {
            Log.Debug(tag, message);
        }

        internal static void Error(string tag, string message)
        {
            Log.Error(tag, message);
        }

        internal static void Info(string tag, string message)
        {
            Log.Info(tag, message);
        }

        internal static void Warn(string tag, string message)
        {
            Log.Warn(tag, message);
        }
    }
}