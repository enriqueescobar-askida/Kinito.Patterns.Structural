namespace Composite
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The composite.
    /// </summary>
    internal class Composite : AbstractComponent
    {
        /// <summary>
        /// The children.
        /// </summary>
        private readonly List<AbstractComponent> children = new List<AbstractComponent>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Composite"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Composite(string name) : base(name)
        {
        }

        /// <summary>
        /// Adds the specified component.
        /// </summary>
        /// <param name="component">The component.</param>
        public override void Add(AbstractComponent component)
        {
            this.children.Add(component);
        }

        /// <summary>
        /// Removes the specified component.
        /// </summary>
        /// <param name="component">The component.</param>
        public override void Remove(AbstractComponent component)
        {
            this.children.Remove(component);
        }

        /// <summary>
        /// Displays the specified depth.
        /// </summary>
        /// <param name="depth">The depth.</param>
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.Name);

            // Recursively display child nodes
            foreach (AbstractComponent component in this.children)
            {
                component.Display(depth + 2);
            }
        }
    }
}