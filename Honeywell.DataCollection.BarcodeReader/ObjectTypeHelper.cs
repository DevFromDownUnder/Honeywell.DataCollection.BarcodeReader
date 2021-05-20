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
                if (value is bool)
                {
                    return new Java.Lang.Boolean(Convert.ToBoolean(value));
                }
                else if (value is int)
                {
                    return new Java.Lang.Integer(Convert.ToInt32(value));
                }
                else if (value is string)
                {
                    return new Java.Lang.String(Convert.ToString(value));
                }
            }
            catch { }

            throw new ArgumentException("Unsupported setting value type: " + value.GetType().FullName);
        }
    }
}