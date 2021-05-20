using System.Collections.Generic;

namespace Honeywell.AIDC.CrossPlatform
{
    /// <summary>Defines the symbology identifiers.</summary>
    public static class BarcodeSymbologies
    {
        /// <summary>Australia Post barcode symbology.</summary>
        public static readonly uint AustraliaPost = 1;

        /// <summary>Aztec barcode symbology.</summary>
        public static readonly uint Aztec = 2;

        /// <summary>British Post barcode symbology.</summary>
        public static readonly uint BritishPost = 3;

        /// <summary>Canadian Postal Service barcode symbology.</summary>
        public static readonly uint CanadaPost = 4;

        /// <summary>Chinese Postal Service symbology.</summary>
        public static readonly uint ChinaPost = 5;

        /// <summary>Codabar barcode symbology.</summary>
        public static readonly uint Codabar = 6;

        /// <summary>Codablock A barcode symbology.</summary>
        public static readonly uint CodablockA = 7;

        /// <summary>Codablock F barcode symbology.</summary>
        public static readonly uint CodablockF = 8;

        /// <summary>Code 11 barcode symbology.</summary>
        public static readonly uint Code11 = 9;

        /// <summary>Code 39 barcode symbology.</summary>
        public static readonly uint Code39 = 10;

        /// <summary>Code 93 barcode symbology.</summary>
        public static readonly uint Code93 = 11;

        /// <summary>Code 128 barcode symbology.</summary>
        public static readonly uint Code128 = 12;

        /// <summary>GS1-128 barcode symbology.</summary>
        public static readonly uint Gs1128 = 13;

        /// <summary>
        ///  International Society of Blood Transfusion (ISBT) 128 barcode symbology.
        /// </summary>
        public static readonly uint Isbt128 = 14;

        /// <summary>Data Matrix barcode symbology.</summary>
        public static readonly uint DataMatrix = 15;

        /// <summary>European Article Number (EAN) 8 barcode symbology.</summary>
        public static readonly uint Ean8 = 16;

        /// <summary>European Article Number (EAN) 13 barcode symbology.</summary>
        public static readonly uint Ean13 = 17;

        /// <summary>Dutch Post barcode symbology.</summary>
        public static readonly uint DutchPost = 18;

        /// <summary>GS1 DataBar Expanded barcode symbology.</summary>
        public static readonly uint Gs1DataBarExpanded = 19;

        /// <summary>GS1 DataBar Limited barcode symbology.</summary>
        public static readonly uint Gs1DataBarLimited = 20;

        /// <summary>GS1 DataBar Omnidirectional barcode symbology.</summary>
        public static readonly uint Gs1DataBarOmniDir = 21;

        /// <summary>Han Xin barcode symbology.</summary>
        public static readonly uint HanXin = 22;

        /// <summary>Infomail barcode symbology.</summary>
        public static readonly uint Infomail = 23;

        /// <summary>
        /// United States Postal Service Intelligent Mail barcode symbology.
        /// </summary>
        public static readonly uint UsIntelligent = 24;

        /// <summary>Interleaved 2 of 5 barcode symbology.</summary>
        public static readonly uint Interleaved2Of5 = 25;

        /// <summary>Matrix 2 of 5 barcode symbology.</summary>
        public static readonly uint Matrix2Of5 = 26;

        /// <summary>Standard 2 of 5 barcode symbology.</summary>
        public static readonly uint Standard2Of5 = 27;

        /// <summary>Java Post barcode symbology.</summary>
        public static readonly uint JanpanPost = 28;

        /// <summary>Korean Post barcode symbology.</summary>
        public static readonly uint KoreanPost = 29;

        /// <summary>Maxicode barcode symbology.</summary>
        public static readonly uint Maxicode = 30;

        /// <summary>Micro PDF417 barcode symbology.</summary>
        public static readonly uint MicroPdf417 = 31;

        /// <summary>MSI barcode symbology.</summary>
        public static readonly uint Msi = 32;

        /// <summary>PDF417 symbology.</summary>
        public static readonly uint PDF417 = 33;

        /// <summary>
        /// United States Postal Service PLANET barcode symbology.
        /// </summary>
        public static readonly uint UsPlanet = 34;

        /// <summary>
        /// United States Postal Numeric Encoding Technique (POSTNET) barcode symbology.
        /// </summary>
        public static readonly uint UsPostNet = 35;

        /// <summary>Quick Response (QR) Code barcode symbology</summary>
        public static readonly uint Qr = 36;

        /// <summary>Sweden Postal barcode symbology.</summary>
        public static readonly uint SwedenPost = 37;

        /// <summary>Telepen barcode symbology.</summary>
        public static readonly uint Telepen = 38;

        /// <summary>TLC 39 barcode symbology.</summary>
        public static readonly uint Tlc39 = 39;

        /// <summary>Tri-Optic Media Storage Devices barcode symbology.</summary>
        public static readonly uint Trioptic39 = 40;

        /// <summary>
        /// Universal Product Code (UPC) version A barcode symbology.
        /// </summary>
        public static readonly uint Upca = 41;

        /// <summary>
        /// Universal Product Code (UPC) version E barcode symbology.
        /// </summary>
        public static readonly uint Upce = 42;

        /// <summary>
        /// Universal Product Code (UPC) Coupon with supplemental barcode symbology.
        /// </summary>
        public static readonly uint UpcCoupon = 43;

        /// <summary>
        /// International Air Transportation Association (IATA) 2 of 5 barcode symbology.
        /// </summary>
        public static readonly uint Iata25 = 44;

        /// <summary>DotCode barcode symbology.</summary>
        public static readonly uint DotCode = 45;

        /// <summary>Grid Matrix barcode symbology.</summary>
        public static readonly uint GridMatrix = 46;

        private static List<SymbologyMap> sSymbologyMappingList = new List<SymbologyMap>()
    {
      new SymbologyMap()
      {
        name = "AUSTRALIAPOST",
        id = BarcodeSymbologies.AustraliaPost,
        honeywellId = "A",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "AZTEC",
        id = BarcodeSymbologies.Aztec,
        honeywellId = "z",
        aimId = "z3"
      },
      new SymbologyMap()
      {
        name = "BPO",
        id = BarcodeSymbologies.BritishPost,
        honeywellId = "B",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "CANADAPOST",
        id = BarcodeSymbologies.CanadaPost,
        honeywellId = "C",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "CHINAPOST",
        id = BarcodeSymbologies.ChinaPost,
        honeywellId = "Q",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "CODABAR",
        id = BarcodeSymbologies.Codabar,
        honeywellId = "a",
        aimId = "F0"
      },
      new SymbologyMap()
      {
        name = "CodablockA",
        id = BarcodeSymbologies.CodablockA,
        honeywellId = "V",
        aimId = "O6"
      },
      new SymbologyMap()
      {
        name = "CodablockF",
        id = BarcodeSymbologies.CodablockF,
        honeywellId = "q",
        aimId = "O4"
      },
      new SymbologyMap()
      {
        name = "Code11",
        id = BarcodeSymbologies.Code11,
        honeywellId = "h",
        aimId = "H1"
      },
      new SymbologyMap()
      {
        name = "Code39",
        id = BarcodeSymbologies.Code39,
        honeywellId = "b",
        aimId = "A0"
      },
      new SymbologyMap()
      {
        name = "Code93",
        id = BarcodeSymbologies.Code93,
        honeywellId = "i",
        aimId = "G0"
      },
      new SymbologyMap()
      {
        name = "Code128",
        id = BarcodeSymbologies.Code128,
        honeywellId = "j",
        aimId = "C0"
      },
      new SymbologyMap()
      {
        name = "DOTCODE",
        id = BarcodeSymbologies.DotCode,
        honeywellId = ".",
        aimId = "J1"
      },
      new SymbologyMap()
      {
        name = "GRIDMATRIX",
        id = BarcodeSymbologies.GridMatrix,
        honeywellId = "X",
        aimId = "g0"
      },
      new SymbologyMap()
      {
        name = "GS1_128",
        id = BarcodeSymbologies.Gs1128,
        honeywellId = "I",
        aimId = "C1"
      },
      new SymbologyMap()
      {
        name = "IATA25",
        id = BarcodeSymbologies.Iata25,
        honeywellId = "f",
        aimId = "R0"
      },
      new SymbologyMap()
      {
        name = "ISBT128",
        id = BarcodeSymbologies.Isbt128,
        honeywellId = "j",
        aimId = "C4"
      },
      new SymbologyMap()
      {
        name = "DATAMATRIX",
        id = BarcodeSymbologies.DataMatrix,
        honeywellId = "w",
        aimId = "d1"
      },
      new SymbologyMap()
      {
        name = "EAN8",
        id = BarcodeSymbologies.Ean8,
        honeywellId = "D",
        aimId = "E4"
      },
      new SymbologyMap()
      {
        name = "EAN13",
        id = BarcodeSymbologies.Ean13,
        honeywellId = "d",
        aimId = "E0"
      },
      new SymbologyMap()
      {
        name = "DUTCHPOST",
        id = BarcodeSymbologies.DutchPost,
        honeywellId = "K",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "GS1EX",
        id = BarcodeSymbologies.Gs1DataBarExpanded,
        honeywellId = "}",
        aimId = "e0"
      },
      new SymbologyMap()
      {
        name = "GS1LI",
        id = BarcodeSymbologies.Gs1DataBarLimited,
        honeywellId = "{",
        aimId = "e0"
      },
      new SymbologyMap()
      {
        name = "GS1OD",
        id = BarcodeSymbologies.Gs1DataBarOmniDir,
        honeywellId = "y",
        aimId = "e0"
      },
      new SymbologyMap()
      {
        name = "HANXIN",
        id = BarcodeSymbologies.HanXin,
        honeywellId = "H",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "INFOMAIL",
        id = BarcodeSymbologies.Infomail,
        honeywellId = ",",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "INTELLIGENTMAIL",
        id = BarcodeSymbologies.UsIntelligent,
        honeywellId = "M",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "ITF",
        id = BarcodeSymbologies.Interleaved2Of5,
        honeywellId = "e",
        aimId = "I0"
      },
      new SymbologyMap()
      {
        name = "ITFMatrix",
        id = BarcodeSymbologies.Matrix2Of5,
        honeywellId = "m",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "ITFStandard",
        id = BarcodeSymbologies.Standard2Of5,
        honeywellId = "f",
        aimId = "S0"
      },
      new SymbologyMap()
      {
        name = "JAPANPOST",
        id = BarcodeSymbologies.JanpanPost,
        honeywellId = "J",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "KOREANPOST",
        id = BarcodeSymbologies.KoreanPost,
        honeywellId = "?",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "MAXICODE",
        id = BarcodeSymbologies.Maxicode,
        honeywellId = "x",
        aimId = "U0"
      },
      new SymbologyMap()
      {
        name = "MICROPDF",
        id = BarcodeSymbologies.MicroPdf417,
        honeywellId = "R",
        aimId = "L0"
      },
      new SymbologyMap()
      {
        name = "MSI",
        id = BarcodeSymbologies.Msi,
        honeywellId = "g",
        aimId = "M0"
      },
      new SymbologyMap()
      {
        name = "PDF417",
        id = BarcodeSymbologies.PDF417,
        honeywellId = "r",
        aimId = "L0"
      },
      new SymbologyMap()
      {
        name = "PLANET",
        id = BarcodeSymbologies.UsPlanet,
        honeywellId = "L",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "POSTNET",
        id = BarcodeSymbologies.UsPostNet,
        honeywellId = "P",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "QR",
        id = BarcodeSymbologies.Qr,
        honeywellId = "s",
        aimId = "Q1"
      },
      new SymbologyMap()
      {
        name = "SWEDENPOST",
        id = BarcodeSymbologies.SwedenPost,
        honeywellId = "[",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "TELEPEN",
        id = BarcodeSymbologies.Telepen,
        honeywellId = "t",
        aimId = "B1"
      },
      new SymbologyMap()
      {
        name = "TLC39",
        id = BarcodeSymbologies.Tlc39,
        honeywellId = "T",
        aimId = "L2"
      },
      new SymbologyMap()
      {
        name = "TRIOPTIC",
        id = BarcodeSymbologies.Trioptic39,
        honeywellId = "=",
        aimId = "X0"
      },
      new SymbologyMap()
      {
        name = "UPCA",
        id = BarcodeSymbologies.Upca,
        honeywellId = "c",
        aimId = "E0"
      },
      new SymbologyMap()
      {
        name = "UPCCoupon",
        id = BarcodeSymbologies.UpcCoupon,
        honeywellId = ";",
        aimId = "E0"
      },
      new SymbologyMap()
      {
        name = "UPCE",
        id = BarcodeSymbologies.Upce,
        honeywellId = "E",
        aimId = "E0"
      }
    };

        /// <summary>
        /// Returns a string name of the specified symbology type.
        /// </summary>
        /// <param name="symbType">A barcode symbology type defined in this class.</param>
        /// <returns>A string name of the specified symbology type.</returns>
        public static string GetName(uint symbType)
        {
            foreach (SymbologyMap symbologyMapping in BarcodeSymbologies.sSymbologyMappingList)
            {
                if ((int)symbologyMapping.id == (int)symbType)
                    return symbologyMapping.name;
            }
            return string.Empty;
        }

        internal static SymbologyMap GetSymbologyMap(string honeywellId, string aimId)
        {
            SymbologyMap symbologyMap = new SymbologyMap(string.Empty, 0U, string.Empty, string.Empty);
            if (honeywellId.Length > 0)
            {
                foreach (SymbologyMap symbologyMapping in BarcodeSymbologies.sSymbologyMappingList)
                {
                    if (symbologyMapping.honeywellId == honeywellId)
                    {
                        if (honeywellId == "j" || honeywellId == "f")
                        {
                            if (symbologyMapping.aimId == aimId)
                            {
                                symbologyMap = symbologyMapping.Clone();
                                break;
                            }
                        }
                        else
                        {
                            symbologyMap = symbologyMapping.Clone();
                            break;
                        }
                    }
                }
            }
            return symbologyMap;
        }
    }
}