namespace Adapter
{
    using System;

    /// <summary>
    /// The abstract compound.
    /// </summary>
    public class AbstractCompound
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCompound"/> class.
        /// </summary>
        /// <param name="chemical">The chemical.</param>
        public AbstractCompound(string chemical)
        {
            this.Chemical = chemical;
        }

        /// <summary>
        /// Gets chemical.
        /// </summary>
        public string Chemical { get; internal set; }

        /// <summary>
        /// Gets boiling point.
        /// </summary>
        public float BoilingPoint { get; internal set; }

        /// <summary>
        /// Gets melting point.
        /// </summary>
        public float MeltingPoint { get; internal set; }

        /// <summary>
        /// Gets molecular weight.
        /// </summary>
        public double MolecularWeight { get; internal set; }

        /// <summary>
        /// Gets molecular formula.
        /// </summary>
        public string MolecularFormula { get; internal set; }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", this.Chemical);
        }
    }
}