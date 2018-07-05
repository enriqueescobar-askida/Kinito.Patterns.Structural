namespace Adapter
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
            // Non-adapted chemical compound
            AbstractCompound unknown = new AbstractCompound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            AbstractCompound water = new RichCompound("Water");
            water.Display();
            AbstractCompound benzene = new RichCompound("Benzene");
            benzene.Display();
            AbstractCompound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user
            Console.ReadKey();

            //
            Client client = new Client();
        }
    }
}
