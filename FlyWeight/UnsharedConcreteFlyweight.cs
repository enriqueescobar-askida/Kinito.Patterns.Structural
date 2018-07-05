namespace FlyWeight
{
    using System;

    /// <summary>
    /// The unshared concrete flyweight.
    /// </summary>
    internal class UnsharedConcreteFlyweight : AbstractFlyweight
    {
        /// <summary>
        /// The operation.
        /// </summary>
        /// <param name="extrinsicstate">
        /// The extrinsicstate.
        /// </param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " + extrinsicstate);
        }
    }
}