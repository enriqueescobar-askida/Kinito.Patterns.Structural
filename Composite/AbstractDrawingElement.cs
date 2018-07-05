namespace Composite
{
    /// <summary>
    /// The abstract drawing element.
    /// </summary>
    public abstract class AbstractDrawingElement
    {
        /// <summary>
        /// The name.
        /// </summary>
        protected string Name;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractDrawingElement"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public AbstractDrawingElement(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Adds the specified d.
        /// </summary>
        /// <param name="d">The d.</param>
        public abstract void Add(AbstractDrawingElement d);

        /// <summary>
        /// Removes the specified d.
        /// </summary>
        /// <param name="d">The d.</param>
        public abstract void Remove(AbstractDrawingElement d);

        /// <summary>
        /// Displays the specified indent.
        /// </summary>
        /// <param name="indent">The indent.</param>
        public abstract void Display(int indent);
    }
}