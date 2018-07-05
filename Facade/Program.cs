namespace Facade
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            TestFirst();
            TestSecond();
        }

        /// <summary>
        /// The test first.
        /// </summary>
        private static void TestFirst()
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
        }
    }
}