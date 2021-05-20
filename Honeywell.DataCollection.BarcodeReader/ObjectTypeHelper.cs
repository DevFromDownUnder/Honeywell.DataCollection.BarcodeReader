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
            Java.Lang.Object @object = (Java.Lang.Object)null;
            if (value != null)
            {
                Type type = value.GetType();
                try
                {
                    if (type == typeof(bool))
                        @object = (Java.Lang.Object)new Java.Lang.Boolean(Convert.ToBoolean(value));
                    else if (type == typeof(int))
                    {
                        @object = (Java.Lang.Object)new Java.Lang.Integer(Convert.ToInt32(value));
                    }
                    else
                    {
                        if (!(type == typeof(string)))
                            throw new ArgumentException("Unsupported setting value type: " + type.FullName);
                        @object = (Java.Lang.Object)new Java.Lang.String(Convert.ToString(value));
                    }
                }
                catch
                {
                    throw new ArgumentException("Unsupported setting value type: " + type.FullName);
                }
            }
            return @object;
        }
    }
}