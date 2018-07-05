namespace Facade
{
    using System;

    /// <summary>
    /// The bank.
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// The has sufficient savings.
        /// </summary>
        /// <param name="customer">
        /// The customer.
        /// </param>
        /// <param name="amount">
        /// The amount.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine("Check bank for " + customer.Name);

            return true;
        } 
    }
}