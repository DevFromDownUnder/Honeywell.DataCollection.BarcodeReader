namespace Honeywell.AIDC.CrossPlatform
{
    /// <summary>
    /// This class provides properties to get the predefined values for certain barcode
    /// related settings. The property name has a prefix of the associated setting key
    /// defined in the <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys" /> class. Application should
    /// create an instance of the <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReader" /> object and use the
    /// <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderBase.SettingValues" /> property of the <see cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReader" />
    /// instance to reference the properties defined in this class.
    /// </summary>
    /// <seealso cref="T:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys" />
    public class BarcodeReaderSettingValues
    {
        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.CodabarCheckDigitMode" />
        /// to specify that checksum check is performed.
        /// </summary>
        public virtual string CodabarCheckDigitMode_Check { get; internal set; } = "check";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.CodabarCheckDigitMode" />
        /// to specify that checksum check is performed and the checksum digit
        /// is stripped from the result string.
        /// </summary>
        public virtual string CodabarCheckDigitMode_CheckAndStrip { get; internal set; } = "checkAndStrip";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.CodabarCheckDigitMode" />
        /// to specify that no checksum checking is performed.
        /// </summary>
        public virtual string CodabarCheckDigitMode_NoCheck { get; internal set; } = "noCheck";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code11CheckDigitMode" />
        /// to specify two checksum digits checked.
        /// </summary>
        public virtual string Code11CheckDigitMode_DoubleDigitCheck { get; internal set; } = "doubleDigitCheck";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code11CheckDigitMode" />
        /// to specify two checksum digits checked and stripped from the result string.
        /// </summary>
        public virtual string Code11CheckDigitMode_DoubleDigitCheckAndStrip { get; internal set; } = "doubleDigitCheckAndStrip";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code11CheckDigitMode" />
        /// to specify one checksum digit checked.
        /// </summary>
        public virtual string Code11CheckDigitMode_SingleDigitCheck { get; internal set; } = "singleDigitCheck";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code11CheckDigitMode" />
        /// to specify one checksum digit checked and stripped from the result string.
        /// </summary>
        public virtual string Code11CheckDigitMode_SingleDigitCheckAndStrip { get; internal set; } = "singleDigitCheckAndStrip";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code128ShortMargin" />
        /// to specify decoding for short margin barcodes is disabled.
        /// </summary>
        public virtual string Code128ShortMargin_Disabled { get; internal set; } = "disabled";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code128ShortMargin" />
        /// to specify decoding for short margin barcodes is enabled for both ends.
        /// </summary>
        public virtual string Code128ShortMargin_EnableBothEnds { get; internal set; } = "full";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code128ShortMargin" />
        /// to specify decoding for short margin barcodes is enabled for short margin
        /// at only one end but not both.
        /// </summary>
        public virtual string Code128ShortMargin_Enabled { get; internal set; } = "partial";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code39CheckDigitMode" />
        /// to specify that checksum check is performed.
        /// </summary>
        public virtual string Code39CheckDigitMode_Check { get; internal set; } = "check";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code39CheckDigitMode" />
        /// to specify that Checksum check is performed and the checksum
        /// digit is stripped from the result string.
        /// </summary>
        public virtual string Code39CheckDigitMode_CheckAndStrip { get; internal set; } = "checkAndStrip";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Code39CheckDigitMode" />
        /// to specify that no checksum checking is performed.
        /// </summary>
        public virtual string Code39CheckDigitMode_NoCheck { get; internal set; } = "noCheck";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.DataProcessorSymbologyPrefix" />
        /// to specify the AIM symbology identifier will be added before the barcode data.
        /// </summary>
        public virtual string DataProcessorSymbologyPrefix_AIM { get; internal set; } = "aim";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.DataProcessorSymbologyPrefix" />
        /// to specify the Honeywell proprietary symbology identifier will be added before the barcode data.
        /// </summary>
        public virtual string DataProcessorSymbologyPrefix_Honeywell { get; internal set; } = "honeywell";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.DataProcessorSymbologyPrefix" />
        /// to specify no symbology identifier will be added before the barcode data.
        /// </summary>
        public virtual string DataProcessorSymbologyPrefix_None { get; internal set; } = "none";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.EanUccEmulationMode" />
        /// to specify GS1-128 emulation.
        /// </summary>
        public virtual string EanUccEmulationMode_Gs1128Emulation { get; internal set; } = "gs1128Emulation";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.EanUccEmulationMode" />
        /// to specify GS1 code expansion off.
        /// </summary>
        public virtual string EanUccEmulationMode_Gs1CodeExpansionOff { get; internal set; } = "gs1CodeExpansionOff";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.EanUccEmulationMode" />
        /// to specify GS1 DataBar emulation.
        /// </summary>
        public virtual string EanUccEmulationMode_Gs1DatabarEmulation { get; internal set; } = "gs1DatabarEmulation";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.EanUccEmulationMode" />
        /// to specify Ean8 to Ean13 conversion.
        /// </summary>
        public virtual string EanUccEmulationMode_Gs1Ean8toEan13Conversion { get; internal set; } = "gs1EAN8toEAN13Conversion";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.EanUccEmulationMode" />
        /// to specify GS1 emulation off.
        /// </summary>
        public virtual string EanUccEmulationMode_Gs1EmulationOff { get; internal set; } = "gs1EmulationOff";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Interleaved25CheckDigitMode" />
        /// to specify checksum check is performed.
        /// </summary>
        public virtual string Interleaved25CheckDigitMode_Check { get; internal set; } = "check";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Interleaved25CheckDigitMode" />
        /// to specify checksum check is performed and the checksum digit is stripped from the result string.
        /// </summary>
        public virtual string Interleaved25CheckDigitMode_CheckAndStrip { get; internal set; } = "checkAndStrip";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Interleaved25CheckDigitMode" />
        /// to specify no checksum checking is performed.
        /// </summary>
        public virtual string Interleaved25CheckDigitMode_NoCheck { get; internal set; } = "noCheck";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.MsiCheckDigitMode" />
        /// to specify no checksum checking is performed.
        /// </summary>
        public virtual string MsiCheckDigitMode_NoCheck { get; internal set; } = "noCheck";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.MsiCheckDigitMode" />
        /// to specify mode 10 checksum check is performed and the checksum digit is stripped from the result string.
        /// </summary>
        public virtual string MsiCheckDigitMode_SingleMod10CheckAndStrip { get; internal set; } = "singleMod10CheckAndStrip";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.MsiCheckDigitMode" />
        /// to specify one mod 10 checksum digit checked.
        /// </summary>
        public virtual string MsiCheckDigitMode_SingleMod10Check { get; internal set; } = "singleMod10Check";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.MsiCheckDigitMode" />
        /// to specify one mod 11 checksum digit plus one mod 10 checksum digit checked.
        /// </summary>
        public virtual string MsiCheckDigitMode_SingleMod11PlusMod10Check { get; internal set; } = "singleMod11PlusMod10Check";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.MsiCheckDigitMode" />
        /// to specify two mod 10 checksum digits checked.
        /// </summary>
        public virtual string MsiCheckDigitMode_DoubleMod10Check { get; internal set; } = "doubleMod10Check";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.MsiCheckDigitMode" />
        /// to specify one mod 11 checksum digit plus one mod 10 checksum digit checked and stripped from the result string.
        /// </summary>
        public virtual string MsiCheckDigitMode_SingleMod11PlusMod10CheckAndStrip { get; internal set; } = "singleMod11PlusMod10CheckAndStrip";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.MsiCheckDigitMode" />
        /// to specify two mod 10 checksum digits checked and stripped from the result string.
        /// </summary>
        public virtual string MsiCheckDigitMode_DoubleMod10CheckAndStrip { get; internal set; } = "doubleMod10CheckAndStrip";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to specify no 2D postal symbologies enabled.
        /// </summary>
        public virtual string Postal2DMode_None { get; internal set; } = "none";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the Australia Post symbology.
        /// </summary>
        public virtual string Postal2DMode_Australia { get; internal set; } = "australia";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the Infomail symbology.
        /// </summary>
        public virtual string Postal2DMode_InfoMail { get; internal set; } = "infomail";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the Japan Post symbology.
        /// </summary>
        public virtual string Postal2DMode_Japan { get; internal set; } = "japan";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the Canadian Postal Service symbology.
        /// </summary>
        public virtual string Postal2DMode_Canada { get; internal set; } = "canada";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the Dutch Post symbology.
        /// </summary>
        public virtual string Postal2DMode_Dutch { get; internal set; } = "dutch";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the United States Postal Service PLANET symbology.
        /// </summary>
        public virtual string Postal2DMode_Planet { get; internal set; } = "planet";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the United States Postal Numeric Encoding Technique (POSTNET) symbology.
        /// </summary>
        public virtual string Postal2DMode_Postnet { get; internal set; } = "postnet";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the British Post symbology.
        /// </summary>
        public virtual string Postal2DMode_Bpo { get; internal set; } = "bpo";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable Infomail and British Post symbologies.
        /// </summary>
        public virtual string Postal2DMode_InfoMailAndBpo { get; internal set; } = "infomailAndBpo";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable UPU symbology.
        /// </summary>
        public virtual string Postal2DMode_Upu { get; internal set; } = "upu";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable the United States Postal Service Intelligent Mail symbology.
        /// </summary>
        public virtual string Postal2DMode_Usps { get; internal set; } = "usps";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable POSTNET with B and B fields.
        /// </summary>
        public virtual string Postal2DMode_PostnetPlusBnb { get; internal set; } = "postnetPlusBnB";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET and POSTNET symbologies.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndPostnet { get; internal set; } = "planetAndPostnet";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET and UPU symbologies.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndUpu { get; internal set; } = "planetAndUpu";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable POSTNET and UPU symbologies.
        /// </summary>
        public virtual string Postal2DMode_PostnetAndUpu { get; internal set; } = "postnetAndUpu";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET and USPS Intelligent Mail symbologies.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndUsps { get; internal set; } = "planetAndUsps";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable POSTNET and USPS Intelligent Mail symbologies.
        /// </summary>
        public virtual string Postal2DMode_PostnetAndUsps { get; internal set; } = "postnetAndUsps";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable UPU and USPS Intelligent Mail symbologies.
        /// </summary>
        public virtual string Postal2DMode_UpuAndUsps { get; internal set; } = "upuAndUsps";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET and POSTNET with B and B fields.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndPostnetPlusBnb { get; internal set; } = "planetAndPostnetPlusBnB";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable POSTNET and UPU with B and B fields.
        /// </summary>
        public virtual string Postal2DMode_PostnetAndUpuPlusBnb { get; internal set; } = "postnetAndUpuPlusBnB";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable POSTNET and USPS Intelligent Mail with B and B fields.
        /// </summary>
        public virtual string Postal2DMode_PostnetAndUspsPlusBnb { get; internal set; } = "postnetAndUspsPlusBnB";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET, POSTNET and UPU symbologies.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndPostnetAndUpu { get; internal set; } = "planetAndPostnetAndUpu";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET, POSTNET and USPS Intelligent Mail symbologies.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndPostnetAndUsps { get; internal set; } = "planetAndPostnetAndUsps";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET, UPU and USPS Intelligent Mail symbologies.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndUpuAndUsps { get; internal set; } = "planetAndUpuAndUsps";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable POSTNET, UPU and USPS Intelligent Mail symbologies.
        /// </summary>
        public virtual string Postal2DMode_PostnetAndUpuAndUsps { get; internal set; } = "postnetAndUpuAndUsps";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET, POSTNET and UPU with B and B fields.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndPostnetAndUpuPlusBnB { get; internal set; } = "planetAndPostnetAndUpuPlusBnB";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET, POSTNET and USPS Intelligent Mail with B and B fields.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndPostnetAndUspsPlusBnB { get; internal set; } = "planetAndPostnetAndUspsPlusBnB";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable POSTNET, UPU and USPS Intelligent Mail with B and B fields.
        /// </summary>
        public virtual string Postal2DMode_PostnetAndUpuAndUspsPlusBnb { get; internal set; } = "postnetAndUpuAndUspsPlusBnB";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET, POSTNET, UPU, and USPS Intelligent Mail symbologies.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndPostnetAndUpuAndUsps { get; internal set; } = "planetAndPostnetAndUpuAndUsps";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.Postal2DMode" />
        /// to enable PLANET, POSTNET, UPU, and USPS Intelligent Mail with B and B fields.
        /// </summary>
        public virtual string Postal2DMode_PlanetAndPostnetAndUpuAndUspsPlusBnb { get; internal set; } = "planetAndPostnetAndUpuAndUspsPlusBnB";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.TriggerScanMode" /> to
        /// continuously decode barcodes when the scan trigger is pressed
        /// until the trigger is released. By default it only decodes unique
        /// barcodes (within the period of trigger pressing and releasing)
        /// unless the <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.TriggerScanSameSymbolTimeoutEnabled" />
        /// property value is true which allows the same barcode to be read
        /// after the <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.TriggerScanSameSymbolTimeout" />
        /// period.
        /// </summary>
        public virtual string TriggerScanMode_Continuous { get; internal set; } = "continuous";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.TriggerScanMode" /> to
        /// scan only one barcode when the scan trigger is pressed.
        /// </summary>
        public virtual string TriggerScanMode_OneShot { get; internal set; } = "oneShot";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.TriggerScanMode" /> to
        /// scan barcode when the trigger is released. Pressing the scan trigger will
        /// start the aimer and releasing the trigger will scan the barcode.
        /// </summary>
        public virtual string TriggerScanMode_ReadOnRelease { get; internal set; } = "readOnRelease";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.TriggerScanMode" /> to
        /// scan barcode when the trigger is pressed the second time. Pressing
        /// the scan trigger first time will start the aimer and pressing the
        /// trigger second time will scan the barcode.
        /// </summary>
        public virtual string TriggerScanMode_ReadOnSecondTriggerPress { get; internal set; } = "readOnSecondTriggerPress";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.VideoReverseEnabled" />
        /// to specify decoding only normal video for 1D codes.
        /// </summary>
        public virtual string VideoReverseEnabled_Normal { get; internal set; } = "normal";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.VideoReverseEnabled" />
        /// to specify decoding only inverse video for 1D codes.
        /// </summary>
        public virtual string VideoReverseEnabled_Inverse { get; internal set; } = "inverse";

        /// <summary>
        /// Setting value for <see cref="P:Honeywell.AIDC.CrossPlatform.BarcodeReaderSettingKeys.VideoReverseEnabled" />
        /// to specify decoding both, normal and inverse video for 1D codes.
        /// </summary>
        public virtual string VideoReverseEnabled_NormalAndInverse { get; internal set; } = "both";

        internal BarcodeReaderSettingValues()
        {
        }
    }
}