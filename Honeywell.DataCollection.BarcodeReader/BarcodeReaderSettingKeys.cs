namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    /// <summary>
    /// This class provides properties for identifying barcode related settings.
    /// Application should create an instance of <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> object
    /// and use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingKeys" /> property of the
    /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference the setting key properties
    /// defined in this class.
    /// </summary>
    /// <seealso cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues" />
    public class BarcodeReaderSettingKeys
    {
        /// <summary>
        /// Setting key to enable or disable the Aztec symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string AztecEnabled { get; internal set; } = "DEC_AZTEC_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Aztec barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string AztecMaximumLength { get; internal set; } = "DEC_AZTEC_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Aztec barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string AztecMininumLength { get; internal set; } = "DEC_AZTEC_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable scanning only near the aimer center. When set to
        /// false, the scanner decodes any bar code in view. When set to true, the scanner
        /// only decodes bar codes that are detected near scan window. By default, the
        /// scan window is a small region near the aimer center. It can be customized
        /// through the DecodeWindow properties.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CenterDecodeEnabled { get; internal set; } = "DEC_WINDOW_MODE";

        /// <summary>
        /// Setting key to enable or disable the China Post symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string ChinaPostEnabled { get; internal set; } = "DEC_HK25_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding China Post barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string ChinaPostMaximumLength { get; internal set; } = "DEC_HK25_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding China Post barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string ChinaPostMinimumLength { get; internal set; } = "DEC_HK25_MIN_LENGTH";

        /// <summary>
        /// Setting key to set the check digit mode for Codabar barcodes.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.CodabarCheckDigitMode_Check" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.CodabarCheckDigitMode_CheckAndStrip" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.CodabarCheckDigitMode_NoCheck" /></item>
        /// </list>
        /// </summary>
        public virtual string CodabarCheckDigitMode { get; internal set; } = "DEC_CODABAR_CHECK_DIGIT_MODE";

        /// <summary>
        /// Setting key to enable or disable Codabar concatenation.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CodabarConcatEnabled { get; internal set; } = "DEC_CODABAR_CONCAT_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the Codabar symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CodabarEnabled { get; internal set; } = "DEC_CODABAR_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Codabar barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string CodabarMaximumLength { get; internal set; } = "DEC_CODABAR_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Codabar barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string CodabarMinimumLength { get; internal set; } = "DEC_CODABAR_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the start/stop transmission for Codabar.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CodabarStartStopTransmitEnabled { get; internal set; } = "DEC_CODABAR_START_STOP_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable the Codablock-A symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CodablockAEnabled { get; internal set; } = "DEC_CODABLOCK_A_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Codablock-A barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string CodablockAMaximumLength { get; internal set; } = "DEC_CODABLOCK_A_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Codablock-A barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string CodablockAMinimumLength { get; internal set; } = "DEC_CODABLOCK_A_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the Codablock-F symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CodablockFEnabled { get; internal set; } = "DEC_CODABLOCK_F_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Codablock-F barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string CodablockFMaximumLength { get; internal set; } = "DEC_CODABLOCK_F_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Codablock-F barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string CodablockFMinimumLength { get; internal set; } = "DEC_CODABLOCK_F_MIN_LENGTH";

        /// <summary>
        /// Setting key to set the check digit mode for Code 11 barcodes.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code11CheckDigitMode_DoubleDigitCheck" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code11CheckDigitMode_DoubleDigitCheckAndStrip" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code11CheckDigitMode_SingleDigitCheck" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code11CheckDigitMode_SingleDigitCheckAndStrip" /></item>
        /// </list>
        /// </summary>
        public virtual string Code11CheckDigitMode { get; internal set; } = "DEC_CODE11_CHECK_DIGIT_MODE";

        /// <summary>
        /// Setting key to enable or disable the Code 11 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Code11Enabled { get; internal set; } = "DEC_CODE11_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Code 11 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Code11MaximumLength { get; internal set; } = "DEC_CODE11_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Code 11 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Code11MinimumLength { get; internal set; } = "DEC_CODE11_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the Code 128 symbology.
        /// </summary>
        public virtual string Code128Enabled { get; internal set; } = "DEC_CODE128_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Code 128 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Code128MaximumLength { get; internal set; } = "DEC_CODE128_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Code 128 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Code128MinimumLength { get; internal set; } = "DEC_CODE128_MIN_LENGTH";

        /// <summary>
        /// Setting key to specify whether substandard length margins (i.e. quiet zones)
        /// should be allowed for Code 128 symbols during the execution of decode.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code128ShortMargin_Disabled" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code128ShortMargin_EnableBothEnds" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code128ShortMargin_Enabled" /></item>
        /// </list>
        /// </summary>
        public virtual string Code128ShortMargin { get; internal set; } = "DEC_C128_SHORT_MARGIN";

        /// <summary>
        /// Setting key to enable or disable Base 32 conversion for Code 39.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Code39Base32Enabled { get; internal set; } = "DEC_CODE39_BASE32_ENABLED";

        /// <summary>
        /// Setting key to set the check digit mode for Code 39 barcodes.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code39CheckDigitMode_Check" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code39CheckDigitMode_CheckAndStrip" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Code39CheckDigitMode_NoCheck" /></item>
        /// </list>
        /// </summary>
        public virtual string Code39CheckDigitMode { get; internal set; } = "DEC_CODE39_CHECK_DIGIT_MODE";

        /// <summary>
        /// Setting key to enable or disable the Code 39 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Code39Enabled { get; internal set; } = "DEC_CODE39_ENABLED";

        /// <summary>
        /// Setting key to enable or disable full ASCII Code 39.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Code39FullAsciiEnabled { get; internal set; } = "DEC_CODE39_FULL_ASCII_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Code 39 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Code39MaximumLength { get; internal set; } = "DEC_CODE39_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Code 39 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Code39MinimumLength { get; internal set; } = "DEC_CODE39_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the start/stop transmission for Code 39.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Code39StartStopTransmitEnabled { get; internal set; } = "DEC_CODE39_START_STOP_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable the Code 93 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Code93Enabled { get; internal set; } = "DEC_CODE93_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Code 93 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Code93MaximumLength { get; internal set; } = "DEC_CODE93_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Code 93 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Code93MinimumLength { get; internal set; } = "DEC_CODE93_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable high density decoding improvements for Code 93.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Code93HighDensity { get; internal set; } = "DEC_CODE93_HIGH_DENSITY";

        /// <summary>
        /// Setting key to enable or disable the combination of parts of
        /// composite codes symbology before returning data.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CombineComposites { get; internal set; } = "DEC_COMBINE_COMPOSITES";

        /// <summary>
        /// Setting key to enable or disable the GS1 Composite symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CompositeEnabled { get; internal set; } = "DEC_COMPOSITE_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding GS1 Composite barcodes.
        /// Codes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string CompositeMaximumLength { get; internal set; } = "DEC_COMPOSITE_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding GS1 Composite barcodes.
        /// Codes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string CompositeMinimumLength { get; internal set; } = "DEC_COMPOSITE_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable UPC code to be read with
        /// PDF417 or MicroPDF417 composite.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string CompositeWithUpcEnabled { get; internal set; } = "DEC_COMPOSITE_WITH_UPC_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the Datamatrix symbology.
        /// </summary>
        public virtual string DatamatrixEnabled { get; internal set; } = "DEC_DATAMATRIX_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Datamatrix barcodes.
        /// Codes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string DatamatrixMaximumLength { get; internal set; } = "DEC_DATAMATRIX_MAX_LENGTH";

        /// <summary>
        /// Setting key to set Minimum code length for decoding Datamatrix barcodes.
        /// Codes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string DatamatrixMinimumLength { get; internal set; } = "DEC_DATAMATRIX_MIN_LENGTH";

        /// <summary>
        /// Setting key to specify the charset used to interpret the barcode byte data.
        /// <para>The value for this setting should be a string containing a charset
        /// name supported by Android.</para>
        /// </summary>
        public virtual string DataProcessorCharset { get; internal set; } = "DPR_CHARSET";

        /// <summary>
        /// Setting key to specify the plug-in to modify the barcode data before
        /// it is delivered in <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.BarcodeDataReady" /> event.
        /// Normally the application can manipulate the barcode data in the
        /// <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.BarcodeDataReady" /> event handler. You may
        /// use this setting if your application provides generic scanning feature
        /// and allows a customer to provide a data editing plug-in to edit the
        /// data according to their requirements.
        /// <para>The value for this setting should be a string in the format of
        /// AppPackageName/.PluginClassName.</para>
        /// </summary>
        public virtual string DataProcessorEditDataPlugin { get; internal set; } = "DPR_EDIT_DATA_PLUGIN";

        /// <summary>
        /// Setting key to specify whether scanning barcodes containing URLs will
        /// open the web browser. Barcodes containing URLs will not cause a
        /// <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.BarcodeDataReady" /> event if this setting
        /// is true. This setting is true by default on Honeywell Android computers.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string DataProcessorLaunchBrowser { get; internal set; } = "DPR_LAUNCH_BROWSER";

        /// <summary>
        /// Setting key to specify whether scanning barcodes generated by EZ Config
        /// for Mobility will launch EZ Config on the mobile computer to apply settings.
        /// Aztec barcodes with "ecfg" near the beginning will not cause a
        /// <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.BarcodeDataReady" /> event if this setting is
        /// true. This setting is true by default on Honeywell Android computers.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string DataProcessorLaunchEZConfig { get; internal set; } = "DPR_LAUNCH_EZ_CONFIG";

        /// <summary>
        /// Setting key to specify the data added to the beginning of the barcode data.
        /// This is often referred to as the preamble.
        /// <para>The value for this setting should be a string.</para>
        /// </summary>
        public virtual string DataProcessorPrefix { get; internal set; } = "DPR_PREFIX";

        /// <summary>
        /// Setting key to specify whether barcodes starting with "//" will attempt
        /// to open an application. If the setting value is true, barcodes with the
        /// format "//<i>NAME</i>" or "//<i>NAME</i>$<i>DATA</i>" will launch an
        /// application listening for an intent with the action
        /// "com.honeywell.scantointent.intent.action.<i>NAME</i>". Data if present
        /// will be included as an extra. The extra key for the data is
        /// "com.honeywell.scantointent.intent.extra.DATA".
        /// <para>Barcodes starting with "//" will not cause a
        /// <see cref="E:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.BarcodeDataReady" /> event if this setting is
        /// true. This setting is true by default on Honeywell Android computers.</para>
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string DataProcessorScanToIntent { get; internal set; } = "DPR_SCAN_TO_INTENT";

        /// <summary>
        /// Setting key to specify the data added to the end of the barcode data.
        /// This is often referred to as the postamble.
        /// <para>The value for this setting should be a string.</para>
        /// </summary>
        public virtual string DataProcessorSuffix { get; internal set; } = "DPR_SUFFIX";

        /// <summary>
        /// Setting key to specify the data added to the beginning of the barcode
        /// data to indicate the symbology. This is added before the data, but
        /// after the prefix specified in <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingKeys.DataProcessorPrefix" />.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.DataProcessorSymbologyPrefix_AIM" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.DataProcessorSymbologyPrefix_Honeywell" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.DataProcessorSymbologyPrefix_None" /></item>
        /// </list>
        /// </summary>
        public virtual string DataProcessorSymbologyPrefix { get; internal set; } = "DPR_SYMBOLOGY_PREFIX";

        /// <summary>
        /// Setting key to set the bottom edge of the scan window within the scanner's
        /// overall image window. A value of 50 is the center of the image window, and 100 is the bottom.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string DecodeWindowBottom { get; internal set; } = "DEC_WINDOW_BOTTOM";

        /// <summary>
        /// Setting key to set the left edge of the scan window within the scanner's
        /// overall image window. A value of 0 is the left edge of the image window, and 50 is the center.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string DecodeWindowLeft { get; internal set; } = "DEC_WINDOW_LEFT";

        /// <summary>
        /// Setting key to set the right edge of the scan window within the scanner's
        /// overall image window. A value of 50 is the center of the image window, and 100 is the right edge.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string DecodeWindowRight { get; internal set; } = "DEC_WINDOW_RIGHT";

        /// <summary>
        /// Setting key to set the top edge of the scan window within the scanner's
        /// overall image window. A value of 0 is the top of the image window, and 50 is the center.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string DecodeWindowTop { get; internal set; } = "DEC_WINDOW_TOP";

        /// <summary>
        /// Setting key to enable or disable the DotCode symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string DotCodeEnabled { get; internal set; } = "DEC_DOTCODE_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding DotCode barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string DotCodeMaximumLength { get; internal set; } = "DEC_DOTCODE_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding DotCode barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string DotCodeMinimumLength { get; internal set; } = "DEC_DOTCODE_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the requirement for EAN-13 add-on 2 or add-on 5 to be enabled.
        /// If enabled, only codes with add-on enabled will be decoded.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean13AddendaRequiredEnabled { get; internal set; } = "DEC_EAN13_ADDENDA_REQUIRED";

        /// <summary>
        /// Setting key to enable or disable adding a space separation between
        /// the EAN-13 bar code data and the add-on characters in the decode result.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean13AddendaSeparatorEnabled { get; internal set; } = "DEC_EAN13_ADDENDA_SEPARATOR";

        /// <summary>
        /// Setting key to enable or disable EAN-13 check digit transmission.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean13CheckDigitTransmitEnabled { get; internal set; } = "DEC_EAN13_CHECK_DIGIT_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable the EAN-13 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean13Enabled { get; internal set; } = "DEC_EAN13_ENABLED";

        /// <summary>
        /// Setting key to enable or disable reading the 5 chars addendum
        /// of EAN-13 barcodes. Failure to decode the full add-on will result
        /// in an overall decode failure.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean13FiveCharAddendaEnabled { get; internal set; } = "DEC_EAN13_5CHAR_ADDENDA_ENABLED";

        /// <summary>
        /// Setting key to enable or disable reading the 2 chars addendum
        /// of EAN-13 barcode. Failure to decode the full add-on will result
        /// in an overall decode failure.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean13TwoCharAddendaEnabled { get; internal set; } = "DEC_EAN13_2CHAR_ADDENDA_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the requirement for EAN-8 add-on 2 or add-on 5 to be enabled.
        /// If enabled, only codes with add-on enabled will be decoded.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean8AddendaRequiredEnabled { get; internal set; } = "DEC_EAN8_ADDENDA_REQUIRED";

        /// <summary>
        /// Setting key to enable or disable adding a space separation between
        /// the EAN-8 bar code data and the add-on characters in the decode result.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean8AddendaSeparatorEnabled { get; internal set; } = "DEC_EAN8_ADDENDA_SEPARATOR";

        /// <summary>
        /// Setting key to enable or disable EAN-8 check digit transmission.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean8CheckDigitTransmitEnabled { get; internal set; } = "DEC_EAN8_CHECK_DIGIT_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable the EAN-8 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean8Enabled { get; internal set; } = "DEC_EAN8_ENABLED";

        /// <summary>
        /// Setting key to enable or disable reading the 5 chars addendum
        /// of EAN-8 barcodes. Failure to decode the full add-on will result
        /// in an overall decode failure.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean8FiveCharAddendaEnabled { get; internal set; } = "DEC_EAN8_5CHAR_ADDENDA_ENABLED";

        /// <summary>
        /// Setting key to enable or disable reading the 2 chars addendum
        /// of EAN-8 barcodes. Failure to decode the full add-on will result
        /// in an overall decode failure.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Ean8TwoCharAddendaEnabled { get; internal set; } = "DEC_EAN8_2CHAR_ADDENDA_ENABLED";

        /// <summary>
        /// Setting key to set EANUCC emulation mode.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.EanUccEmulationMode_Gs1128Emulation" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.EanUccEmulationMode_Gs1CodeExpansionOff" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.EanUccEmulationMode_Gs1DatabarEmulation" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.EanUccEmulationMode_Gs1Ean8toEan13Conversion" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.EanUccEmulationMode_Gs1EmulationOff" /></item>
        /// </list>
        /// </summary>
        public virtual string EanUccEmulationMode { get; internal set; } = "DEC_EANUCC_EMULATION_MODE";

        /// <summary>
        /// Setting key to enable or disable the Grid Matrix symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string GridMatrixEnabled { get; internal set; } = "DEC_GRIDMATRIX_ENABLED";

        /// <summary>
        /// Setting key to set the maximum length for decoding Grid Matrix barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string GridMatrixMaximumLength { get; internal set; } = "DEC_GRIDMATRIX_MAX_LENGTH";

        /// <summary>
        /// Setting key to set the minimum length for decoding Grid Matrix barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string GridMatrixMinimumLength { get; internal set; } = "DEC_GRIDMATRIX_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the GS1-128 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Gs1128Enabled { get; internal set; } = "DEC_GS1_128_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding GS1-128 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Gs1128MaximumLength { get; internal set; } = "DEC_GS1_128_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding GS1-128 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Gs1128MinimumLength { get; internal set; } = "DEC_GS1_128_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the Han Xin symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string HanXinEnabled { get; internal set; } = "DEC_HANXIN_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Han Xin barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string HanXinMaximumLength { get; internal set; } = "DEC_HANXIN_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding Han Xin barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string HanXinMinimumLength { get; internal set; } = "DEC_HANXIN_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the International Air
        /// Transportation Association (IATA) 2 of 5 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Iata25Enabled { get; internal set; } = "DEC_IATA25_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding IATA 2 of 5 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Iata25MaximumLength { get; internal set; } = "DEC_IATA25_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding IATA 2 of 5 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Iata25MinimumLength { get; internal set; } = "DEC_IATA25_MIN_LENGTH";

        /// <summary>
        /// Setting key to set the check digit mode for Interleaved 2 of 5 barcodes.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Interleaved25CheckDigitMode_Check" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Interleaved25CheckDigitMode_CheckAndStrip" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Interleaved25CheckDigitMode_NoCheck" /></item>
        /// </list>
        /// </summary>
        public virtual string Interleaved25CheckDigitMode { get; internal set; } = "DEC_I25_CHECK_DIGIT_MODE";

        /// <summary>
        /// Setting key to enable or disable the Interleaved 2 of 5 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Interleaved25Enabled { get; internal set; } = "DEC_I25_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Interleaved 2 of 5 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Interleaved25MaximumLength { get; internal set; } = "DEC_I25_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding Interleaved 2 of 5 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Interleaved25MinimumLength { get; internal set; } = "DEC_I25_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the ISBT 128 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Isbt128Enabled { get; internal set; } = "DEC_C128_ISBT_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the Korean Post symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string KoreanPostEnabled { get; internal set; } = "DEC_KOREA_POST_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Korean Post barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string KoreanPostMaximumLength { get; internal set; } = "DEC_KOREA_POST_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding Korean Post barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string KoreanPostMinimumLength { get; internal set; } = "DEC_KOREA_POST_MIN_LENGTH";

        /// <summary>
        /// Setting key for enabling this function when scanning damaged or badly printed 1-D bar codes.
        /// This setting enhances the ability to read these types of bar codes.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string LinearDamageImprovements { get; internal set; } = "DEC_LINEAR_DAMAGE_IMPROVEMENTS";

        /// <summary>
        /// Setting key to enable or disable the Matrix 2 of 5 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Matrix25Enabled { get; internal set; } = "DEC_M25_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Matrix 2 of 5 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Matrix25MaximumLength { get; internal set; } = "DEC_M25_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding Matrix 2 of 5 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Matrix25MinimumLength { get; internal set; } = "DEC_M25_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the Maxicode symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string MaxicodeEnabled { get; internal set; } = "DEC_MAXICODE_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Maxicode barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string MaxicodeMaximumLength { get; internal set; } = "DEC_MAXICODE_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding Maxicode barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string MaxicodeMinimumLength { get; internal set; } = "DEC_MAXICODE_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the Micro PDF417 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string MicroPdf417Enabled { get; internal set; } = "DEC_MICROPDF_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Micro PDF417 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string MicroPdf417MaximumLength { get; internal set; } = "DEC_MICROPDF_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding Micro PDF417 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string MicroPdf417MinimumLength { get; internal set; } = "DEC_MICROPDF_MIN_LENGTH";

        /// <summary>
        /// Setting key to set the check digit mode for MSI barcodes.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.MsiCheckDigitMode_DoubleMod10Check" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.MsiCheckDigitMode_DoubleMod10CheckAndStrip" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.MsiCheckDigitMode_NoCheck" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.MsiCheckDigitMode_SingleMod10Check" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.MsiCheckDigitMode_SingleMod10CheckAndStrip" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.MsiCheckDigitMode_SingleMod11PlusMod10Check" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.MsiCheckDigitMode_SingleMod11PlusMod10CheckAndStrip" /></item>
        /// </list>
        /// </summary>
        public virtual string MsiCheckDigitMode { get; internal set; } = "DEC_MSI_CHECK_DIGIT_MODE";

        /// <summary>
        /// Setting key to enable or disable the MSI symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string MsiEnabled { get; internal set; } = "DEC_MSI_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding MSI barcodes.
        /// Barcodes that don't meet the maximum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string MsiMaximumLength { get; internal set; } = "DEC_MSI_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding MSI barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string MsiMinimumLength { get; internal set; } = "DEC_MSI_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable out of spec MSI codes.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string MsiOutOfSpecSymbol { get; internal set; } = "DEC_PROP_MSIP_OUT_OF_SPEC_SYMBOL";

        /// <summary>
        /// Setting key to enable or disable reading MSI with short margin
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string MsiShortMargin { get; internal set; } = "DEC_MSIP_SHORT_MARGIN";

        /// <summary>
        /// Setting key to enable or disable the bad read notifications. This setting
        /// determines whether the bad read beep will play when no bar code is decoded.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string NotificationBadReadEnabled { get; internal set; } = "NTF_BAD_READ_ENABLED";

        /// <summary>
        /// Setting key to enable or disable good read notifications. This setting
        /// determines whether the good read beep will play on successful decode.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string NotificationGoodReadEnabled { get; internal set; } = "NTF_GOOD_READ_ENABLED";

        /// <summary>
        /// Setting key to enable or disable vibration during notifications.
        /// This setting determines whether the device will vibrate when a
        /// notification occurs. Note that this setting is ignored if the
        /// device's ringer mode is set to SILENT.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string NotificationVibrateEnabled { get; internal set; } = "NTF_VIBRATE_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the PDF417 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Pdf417Enabled { get; internal set; } = "DEC_PDF417_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding PDF417 barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Pdf417MaximumLength { get; internal set; } = "DEC_PDF417_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding PDF417 barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Pdf417MinimumLength { get; internal set; } = "DEC_PDF417_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable one or more 2D postal symbologies. Enabling one
        /// grouping option means disabling the previously selected grouping.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Australia" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Bpo" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Canada" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Dutch" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_InfoMail" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_InfoMailAndBpo" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Japan" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_None" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Planet" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndPostnet" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndPostnetAndUpu" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndPostnetAndUpuAndUsps" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndPostnetAndUpuAndUspsPlusBnb" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndPostnetAndUpuPlusBnB" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndPostnetAndUsps" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndPostnetAndUspsPlusBnB" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndPostnetPlusBnb" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndUpu" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndUpuAndUsps" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PlanetAndUsps" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Postnet" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PostnetAndUpu" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PostnetAndUpuAndUsps" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PostnetAndUpuAndUspsPlusBnb" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PostnetAndUpuPlusBnb" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PostnetAndUsps" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PostnetAndUspsPlusBnb" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_PostnetPlusBnb" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Upu" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_UpuAndUsps" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.Postal2DMode_Usps" /></item>
        /// </list>
        /// </summary>
        public virtual string Postal2DMode { get; internal set; } = "DEC_POSTAL_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the check digit transmission for PLANET barcodes.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string PlanetCheckDigitTransmitEnabled { get; internal set; } = "DEC_PLANETCODE_CHECK_DIGIT_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable the check digit transmission for POSTNET barcodes.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string PostnetCheckDigitTransmitEnabled { get; internal set; } = "DEC_POSTNET_CHECK_DIGIT_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable the QR Code symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string QrCodeEnabled { get; internal set; } = "DEC_QR_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding QR Code barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string QrCodeMaximumLength { get; internal set; } = "DEC_QR_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding QR Code barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string QrCodeMinimumLength { get; internal set; } = "DEC_QR_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the GS1 DataBar Omnidirectional symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string RssEnabled { get; internal set; } = "DEC_RSS_14_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the GS1 DataBar Expanded symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string RssExpandedEnabled { get; internal set; } = "DEC_RSS_EXPANDED_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding GS1 DataBar Expanded
        /// barcodes. Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string RssExpandedMaximumLength { get; internal set; } = "DEC_RSS_EXPANDED_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding GS1 DataBar Expanded
        /// barcodes. Barcodes that don't meet the minimum length requirement
        /// will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string RssExpandedMinimumLength { get; internal set; } = "DEC_RSS_EXPANDED_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the GS1 DataBar Limited symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string RssLimitedEnabled { get; internal set; } = "DEC_RSS_LIMITED_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the Standard 2 of 5 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Standard25Enabled { get; internal set; } = "DEC_S25_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Standard 2 of 5
        /// barcodes. Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Standard25MaximumLength { get; internal set; } = "DEC_S25_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding Standard 2 of 5
        /// barcodes. Barcodes that don't meet the minimum length requirement
        /// will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string Standard25MinimumLength { get; internal set; } = "DEC_S25_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable the Telepen symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string TelepenEnabled { get; internal set; } = "DEC_TELEPEN_ENABLED";

        /// <summary>
        /// Setting key to set maximum code length for decoding Telepen barcodes.
        /// Barcodes exceeding the maximum length will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string TelepenMaximumLength { get; internal set; } = "DEC_TELEPEN_MAX_LENGTH";

        /// <summary>
        /// Setting key to set minimum code length for decoding Telepen barcodes.
        /// Barcodes that don't meet the minimum length requirement will not be decoded.
        /// <para>The value for this setting should be an integer.</para>
        /// </summary>
        public virtual string TelepenMinimumLength { get; internal set; } = "DEC_TELEPEN_MIN_LENGTH";

        /// <summary>
        /// Setting key to enable or disable old-style Telepen.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string TelepenOldStyleEnabled { get; internal set; } = "DEC_TELEPEN_OLD_STYLE";

        /// <summary>
        /// Setting key to enable or disable the TLC 39 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string Tlc39Enabled { get; internal set; } = "DEC_TLC39_ENABLED";

        /// <summary>
        /// Setting key to set the delay before starting to scan after the aimer is turned on.
        /// <para>The value for this setting should be an integer (in milliseconds).</para>
        /// </summary>
        public virtual string TriggerScanDelay { get; internal set; } = "TRIG_SCAN_DELAY";

        /// <summary>
        /// Setting key to set the trigger scan mode.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.TriggerScanMode_Continuous" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.TriggerScanMode_OneShot" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.TriggerScanMode_ReadOnRelease" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.TriggerScanMode_ReadOnSecondTriggerPress" /></item>
        /// </list>
        /// </summary>
        public virtual string TriggerScanMode { get; internal set; } = "TRIG_SCAN_MODE";

        /// <summary>
        /// Setting key to set the time period before the scanner can reread the same
        /// barcode in continuous trigger scan mode.
        /// <para>The value for this setting should be an integer (in milliseconds).</para>
        /// <seealso cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingKeys.TriggerScanMode" />
        /// <seealso cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.TriggerScanMode_Continuous" />
        /// </summary>
        public virtual string TriggerScanSameSymbolTimeout { get; internal set; } = "TRIG_SCAN_SAME_SYMBOL_TIMEOUT";

        /// <summary>
        /// Setting key to enable or disable same symbol timeout. If the setting
        /// value is true, you may specify the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingKeys.TriggerScanSameSymbolTimeout" /> to
        /// allow the scanner to reread the same barcode in continuous trigger scan mode.
        /// <para>The value for this setting should be boolean.</para>
        /// <seealso cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingKeys.TriggerScanMode" />
        /// <seealso cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.TriggerScanMode_Continuous" />
        /// </summary>
        public virtual string TriggerScanSameSymbolTimeoutEnabled { get; internal set; } = "TRIG_SCAN_SAME_SYMBOL_TIMEOUT_ENABLED";

        /// <summary>
        /// Setting key to set the trigger timeout. The behavior depends on the scanner.
        /// For Honeywell internal scanners, this setting indicates how long the scanner
        /// will remain on while the scan trigger is pressed. Once this timeout has
        /// expired, the scanner will be automatically turned off to save power.
        /// <para>The value for this setting should be an integer (in seconds).</para>
        /// </summary>
        public virtual string TriggerTimeout { get; internal set; } = "TRIG_AUTO_MODE_TIMEOUT";

        /// <summary>
        /// Setting key to enable or disable the Trioptic symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string TriopticEnabled { get; internal set; } = "DEC_TRIOPTIC_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the requirement for UPCA add-on 2 or
        /// add-on 5 to be enabled. If enabled, only codes with add-on enabled will be decoded.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcAAddendaRequiredEnabled { get; internal set; } = "DEC_UPCA_ADDENDA_REQUIRED";

        /// <summary>
        /// Setting key to enable or disable adding a space separation between
        /// the UPCA bar code data and the add-on characters in the decode result.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcAAddendaSeparatorEnabled { get; internal set; } = "DEC_UPCA_ADDENDA_SEPARATOR";

        /// <summary>
        /// Setting key to enable or disable the check digit transmission for UPCA barcodes.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcACheckDigitTransmitEnabled { get; internal set; } = "DEC_UPCA_CHECK_DIGIT_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable UPC-A Coupon Extended Code. If enabled,
        /// the primary UPC-A coupon code with a supplemental barcode can be decoded
        /// and the data are combined.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcACombineCouponCodeModeEnabled { get; internal set; } = "DEC_COMBINE_COUPON_CODES";

        /// <summary>
        /// Setting key to enable or disable UPC-A Coupon Code.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcACouponCodeModeEnabled { get; internal set; } = "DEC_COUPON_CODE_MODE";

        /// <summary>
        /// Setting key to enable or disable the UPC-A symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcAEnable { get; internal set; } = "DEC_UPCA_ENABLE";

        /// <summary>
        /// Setting key to enable or disable UPC-A add-on 5. Failure to decode
        /// the full add-on will result in an overall decode failure.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcAFiveCharAddendaEnabled { get; internal set; } = "DEC_UPCA_5CHAR_ADDENDA_ENABLED";

        /// <summary>
        /// Setting key to enable or disable UPC-A number system transmission.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcANumberSystemTransmitEnabled { get; internal set; } = "DEC_UPCA_NUMBER_SYSTEM_TRANSMIT";

        /// <summary>
        /// Setting key to translate UPC-A to EAN13.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcATranslateEan13 { get; internal set; } = "DEC_UPCA_TRANSLATE_TO_EAN13";

        /// <summary>
        /// Setting key to enable or disable UPC-A add-on 2. Failure to decode
        /// the full add-on will result in an overall decode failure.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcATwoCharAddendaEnabled { get; internal set; } = "DEC_UPCA_2CHAR_ADDENDA_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the requirement for UPC-E add-on 2 or
        /// add-on 5 to be enabled. If enabled, only codes with add-on enabled will be decoded.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcEAddendaRequiredEnabled { get; internal set; } = "DEC_UPCE_ADDENDA_REQUIRED";

        /// <summary>
        /// Setting key to enable or disable adding a space separation between the
        /// UPC-E barcode data and the add-on characters in the decode result.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcEAddendaSeparatorEnabled { get; internal set; } = "DEC_UPCE_ADDENDA_SEPARATOR";

        /// <summary>
        /// Setting key to enable or disable the check digit transmission for UPC-E barcodes.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcECheckDigitTransmitEnabled { get; internal set; } = "DEC_UPCE_CHECK_DIGIT_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable the UPC-E1 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcE1Enabled { get; internal set; } = "DEC_UPCE1_ENABLED";

        /// <summary>
        /// Setting key to enable or disable the UPC-E0 symbology.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcEEnabled { get; internal set; } = "DEC_UPCE0_ENABLED";

        /// <summary>
        /// Setting key to enable or disable expanding a UPC-E barcode into a UPC-A standard code.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcEExpandToUpcA { get; internal set; } = "DEC_UPCE_EXPAND";

        /// <summary>
        /// Setting key to enable or disable UPC-E add-on 5. Failure to decode
        /// the full add-on will result in an overall decode failure.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcEFiveCharAddendaEnabled { get; internal set; } = "DEC_UPCE_5CHAR_ADDENDA_ENABLED";

        /// <summary>
        /// Setting key to enable or disable UPC-E number system transmission.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcENumberSystemTransmitEnabled { get; internal set; } = "DEC_UPCE_NUMBER_SYSTEM_TRANSMIT";

        /// <summary>
        /// Setting key to enable or disable UPC-E add-on 2. Failure to decode
        /// the full add-on will result in an overall decode failure.
        /// <para>The value for this setting should be boolean.</para>
        /// </summary>
        public virtual string UpcETwoCharAddendaEnabled { get; internal set; } = "DEC_UPCE_2CHAR_ADDENDA_ENABLED";

        /// <summary>
        /// Setting key to specify whether normal or inverse decoding for linear symbologies
        /// is enabled during the execution of decode. By default normal video is enabled.
        /// <para>The value for this setting should be one of the values below.
        /// Use the <see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderBase.SettingValues" /> property of the
        /// <see cref="T:DevFromDownUnder.Honeywell.DataCollection.BarcodeReader" /> instance to reference these predefined values.</para>
        /// <list type="bullet">
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.VideoReverseEnabled_Inverse" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.VideoReverseEnabled_Normal" /></item>
        /// <item><see cref="P:DevFromDownUnder.Honeywell.DataCollection.BarcodeReaderSettingValues.VideoReverseEnabled_NormalAndInverse" /></item>
        /// </list>
        /// </summary>
        public virtual string VideoReverseEnabled { get; internal set; } = "DEC_VIDEO_REVERSE_ENABLED";

        internal BarcodeReaderSettingKeys()
        {
        }
    }
}