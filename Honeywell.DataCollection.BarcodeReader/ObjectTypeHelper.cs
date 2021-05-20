using System;

namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// An internal helper class to convert object types between C# and Java.
    /// </summary>
    internal static class ObjectTypeHelper
    {
        /// <summary>Converts a C# object to a Java object.</summary>
        /// <param name="value">A C# object.</param>
        /// <returns>A Java object.</returns>
        public static Java.Lang.Object ConvertSettingValueToJavaObject(object value)
        {
            if (value == null)
            {
                return null;
            }

            try
            {
                //Haven't checked I guess types are only bool, int and string?
                if (value is bool boolValue)
                {
                    return new Java.Lang.Boolean(boolValue);
                }
                else if (value is int intValue)
                {
                    return new Java.Lang.Integer(intValue);
                }
                else if (value is string stringValue)
                {
                    return new Java.Lang.String(stringValue);
                }
            }
            catch { }

            throw new ArgumentException("Unsupported setting value type: " + value.GetType().FullName);
        }

        public static object ConvertJavaObjectToSettingValue(Java.Lang.Object value)
        {
            if (value == null)
            {
                return null;
            }

            try
            {
                //Haven't checked I guess types are only bool, int and string?
                if (value is Java.Lang.Boolean javaBoolean)
                {
                    return Convert.ToBoolean(javaBoolean);
                }
                else if (value is Java.Lang.Integer javaInteger)
                {
                    return Convert.ToInt32(javaInteger);
                }
                else if (value is Java.Lang.String javaString)
                {
                    return Convert.ToString(javaString);
                }
            }
            catch { }

            throw new ArgumentException("Unsupported setting value type: " + value.GetType().FullName);
        }
    }
}