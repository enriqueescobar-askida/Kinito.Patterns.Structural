namespace FlyWeight
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
            // Build a document with text
            const string Document = "AAZZBBZB";
            char[] chars = Document.ToCharArray();
            CharacterFactory characterFactory = new CharacterFactory();

            // extrinsic state
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (char c in chars)
            {
                pointSize++;
                AbstractCharacter abstractCharacter = characterFactory.GetCharacter(c);
                abstractCharacter.Display(pointSize);
            }

            // Wait for user
            Console.ReadKey();
        }

        /// <summary>
        /// The test second.
        /// </summary>
        private static void TestSecond()
        {
            // Arbitrary extrinsic state
            int extrinsicstate = 22;
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            // Work with different flyweight instances
            AbstractFlyweight fx = flyweightFactory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);
            AbstractFlyweight fy = flyweightFactory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);
            AbstractFlyweight fz = flyweightFactory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);
            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();
            fu.Operation(--extrinsicstate);

            // Wait for user
            Console.ReadKey();
        }
    }
}