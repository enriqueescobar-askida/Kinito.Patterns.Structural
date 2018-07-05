namespace Composite
{
    using System;

    internal class Leaf : AbstractComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Leaf"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Leaf(string name) : base(name)
        {
        }

        /// <summary>
        /// Adds the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        public override void Add(AbstractComponent c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }

        /// <summary>
        /// Removes the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        public override void Remove(AbstractComponent c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }

        /// <summary>
        /// Displays the specified depth.
        /// </summary>
        /// <param name="depth">The depth.</param>
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + this.Name);
        }
    }
}