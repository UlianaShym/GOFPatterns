namespace GofPatternsFun.Structural.Adapter.OldLogic
{
    class ChemicalDatabank
    {
        // The databank 'legacy API'
        public float GetCriticalPoint(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 100.0f;
                case "benzene": return 80.1f;
                case "ethanol": return 78.3f;
                default: return 0f;
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }

    }
}
