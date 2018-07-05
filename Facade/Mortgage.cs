namespace Facade
{
    using System;

    /// <summary>
    /// The mortgage.
    /// </summary>
    public class Mortgage
    {
        /// <summary>
        /// Gets the bank.
        /// </summary>
        public Bank Bank { get; internal set; }

        /// <summary>
        /// Gets the loan.
        /// </summary>
        public Loan Loan { get; internal set; }

        /// <summary>
        /// Gets the credit.
        /// </summary>
        public Credit Credit { get; internal set; }

        /// <summary>
        /// The is eligible.
        /// </summary>
        /// <param name="amount">
        /// The amount.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsEligible(Customer customer, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", customer.Name, amount);
            bool eligible = true;

            // Check creditworthyness of applicant
            if (!this.Bank.HasSufficientSavings(customer, amount)) eligible = false;
            else if (!this.Loan.HasNoBadLoans(customer)) eligible = false;
            else if (!this.Credit.HasGoodCredit(customer)) eligible = false;

            return false;
        }
    }
}