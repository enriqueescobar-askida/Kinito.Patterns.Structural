namespace Adapter
{
    using System;

    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    internal class RichCompound : AbstractCompound
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RichCompound"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public RichCompound(string name) : base(name)
        {
        }

        /// <summary>
        /// Gets the chemical databank.
        /// </summary>
        public ChemicalDatabank ChemicalDatabank { get; internal set; }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public override void Display()
        {
            // The Adaptee
            this.ChemicalDatabank = new ChemicalDatabank();
            this.BoilingPoint = this.ChemicalDatabank.GetCriticalPoint(this.Chemical, "B");
            this.MeltingPoint = this.ChemicalDatabank.GetCriticalPoint(this.Chemical, "M");
            this.MolecularWeight = this.ChemicalDatabank.GetMolecularWeight(this.Chemical);
            this.MolecularFormula = this.ChemicalDatabank.GetMolecularStructure(this.Chemical);
            base.Display();
            Console.WriteLine(" Formula: {0}", this.MolecularFormula);
            Console.WriteLine(" Weight : {0}", this.MolecularWeight);
            Console.WriteLine(" Melting Pt: {0}", this.MeltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", this.BoilingPoint);
        }
    }
}