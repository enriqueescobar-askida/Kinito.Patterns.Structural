namespace Composite
{
    /// <summary>
    /// The abstract component.
    /// </summary>
    internal abstract class AbstractComponent
    {
        /// <summary>
        /// The name.
        /// </summary>
        protected string Name;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractComponent"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public AbstractComponent(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Adds the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        public abstract void Add(AbstractComponent c);

        /// <summary>
        /// Removes the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        public abstract void Remove(AbstractComponent c);

        /// <summary>
        /// Displays the specified depth.
        /// </summary>
        /// <param name="depth">The depth.</param>
        public abstract void Display(int depth);
    }
}