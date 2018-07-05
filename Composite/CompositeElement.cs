namespace Composite
{
    using System;
    using System.Collections.Generic;

    internal class CompositeElement : AbstractDrawingElement
    {
        private List<AbstractDrawingElement> _elements = new List<AbstractDrawingElement>();

        public CompositeElement(string name) : base(name)
        {
        }

        /// <summary>
        /// Adds the specified d.
        /// </summary>
        /// <param name="d">The d.</param>
        public override void Add(AbstractDrawingElement d)
        {
            this._elements.Add(d);
        }

        /// <summary>
        /// Removes the specified d.
        /// </summary>
        /// <param name="d">The d.</param>
        public override void Remove(AbstractDrawingElement d)
        {
            this._elements.Remove(d);
        }

        /// <summary>
        /// Displays the specified indent.
        /// </summary>
        /// <param name="indent">The indent.</param>
        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + this.Name);
            // Display each child element on this node
            foreach (AbstractDrawingElement d in this._elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}