namespace Bridge
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Mains the specified args.
        /// </summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            TestBridge();
            TestBridgeTwo();
        }

        /// <summary>
        /// The test bridge two.
        /// </summary>
        private static void TestBridgeTwo()
        {
            // Create RefinedAbstraction
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor
            customers.Data = new CustomersData();

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test bridge.
        /// </summary>
        private static void TestBridge()
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();

            // Wait for user
            Console.ReadKey();
        }
    }
}