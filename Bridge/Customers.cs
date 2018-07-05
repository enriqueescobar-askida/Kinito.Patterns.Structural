namespace Bridge
{
    using System;

    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class Customers : CustomersBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customers"/> class.
        /// </summary>
        /// <param name="group">The group.</param>
        public Customers(string group)
            : base(group)
        {
        }

        /// <summary>
        /// Shows all.
        /// </summary>
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}