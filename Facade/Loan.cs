namespace Facade
{
    using System;

    /// <summary>
    /// The loan.
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// The has no bad loans.
        /// </summary>
        /// <param name="customer">
        /// The customer.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine("Check loans for " + customer.Name);

            return true;
        }
    }
}