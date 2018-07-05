namespace Composite
{
    using System;

    /// <summary>
    /// The primitive element.
    /// </summary>
    internal class PrimitiveElement : AbstractDrawingElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrimitiveElement"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public PrimitiveElement(string name) : base(name)
        {
        }

        /// <summary>
        /// Adds the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        public override void Add(AbstractDrawingElement c)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        /// <summary>
        /// Removes the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        public override void Remove(AbstractDrawingElement c)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        /// <summary>
        /// Displays the specified indent.
        /// </summary>
        /// <param name="indent">The indent.</param>
        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + this.Name);
        }
    }
}