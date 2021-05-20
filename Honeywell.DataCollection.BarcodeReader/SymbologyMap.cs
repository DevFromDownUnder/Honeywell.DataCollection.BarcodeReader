namespace DevFromDownUnder.Honeywell.DataCollection.BarcodeReader
{
    internal class SymbologyMap
    {
        internal string name;
        internal uint id;
        internal string honeywellId;
        internal string aimId;

        public SymbologyMap()
        {
        }

        public SymbologyMap(string name, uint id, string honeywellId, string aimId)
        {
            this.name = name;
            this.id = id;
            this.honeywellId = honeywellId;
            this.aimId = aimId;
        }

        public SymbologyMap Clone()
        {
            return MemberwiseClone() as SymbologyMap;
        }
    }
}