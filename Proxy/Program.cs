namespace Proxy
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
            // Create proxy and request a service
            Proxy proxy = new Proxy();
            proxy.Request();

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            // Create math proxy
            MathProxy proxy = new MathProxy();

            // Do the math
            Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            // Wait for user
            Console.ReadKey();
        }
    }
}