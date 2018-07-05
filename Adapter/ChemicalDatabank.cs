namespace Adapter
{
    /// <summary>
    /// The chemical databank.
    /// </summary>
    public class ChemicalDatabank
    {
        /// <summary>
        /// The get critical point.
        /// </summary>
        /// The databank 'legacy API'
        /// Gets the critical point.
        /// <param name="compound">
        /// The compound.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="float"/>.
        /// </returns>
        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            else // Boiling Point
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        /// <summary>
        /// Gets the molecular structure.
        /// </summary>
        /// <param name="compound">
        /// The compound.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
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

        /// <summary>
        /// Gets the molecular weight.
        /// </summary>
        /// <param name="compound">
        /// The compound.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}