namespace Facade
{
    /// <summary>
    /// The customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public Customer(string name)
        {
            this.Name = name;
        }
    }
}