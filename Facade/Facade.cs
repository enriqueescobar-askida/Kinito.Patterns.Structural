namespace Facade
{
    using System;

    /// <summary>
    /// The facade.
    /// </summary>
    public class Facade
    {
        /// <summary>
        /// Gets the sub system one.
        /// </summary>
        public SubSystemOne SubSystemOne { get; internal set; }

        /// <summary>
        /// Gets the sub system two.
        /// </summary>
        public SubSystemTwo SubSystemTwo { get; internal set; }

        /// <summary>
        /// Gets the sub system three.
        /// </summary>
        public SubSystemThree SubSystemThree { get; internal set; }

        /// <summary>
        /// Gets the sub system four.
        /// </summary>
        public SubSystemFour SubSystemFour { get; internal set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Facade"/> class.
        /// </summary>
        public Facade()
        {
            this.SubSystemOne = new SubSystemOne();
            this.SubSystemTwo = new SubSystemTwo();
            this.SubSystemThree = new SubSystemThree();
            this.SubSystemFour = new SubSystemFour();
        }

        /// <summary>
        /// The method a.
        /// </summary>
        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ---- ");
            this.SubSystemOne.MethodOne();
            this.SubSystemTwo.MethodTwo();
            this.SubSystemFour.MethodFour();
        }

        /// <summary>
        /// The method b.
        /// </summary>
        public void MethodB()
        {
            Console.WriteLine("\nMethodB() ---- ");
            this.SubSystemTwo.MethodTwo();
            this.SubSystemThree.MethodThree();
        }
    }
}