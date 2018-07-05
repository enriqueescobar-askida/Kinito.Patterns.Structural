namespace Facade
{
    using System;

    /// <summary>
    /// The credit.
    /// </summary>
    public class Credit
    {
        /// <summary>
        /// The has good credit.
        /// </summary>
        /// <param name="customer">
        /// The customer.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine("Check credit for " + customer.Name);

            return true;
        } 
    }
}