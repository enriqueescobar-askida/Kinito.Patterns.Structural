namespace FlyWeight
{
    using System;

    /// <summary>
    /// The concrete flyweight.
    /// </summary>
    internal class ConcreteFlyweight : AbstractFlyweight
    {
        /// <summary>
        /// The operation.
        /// </summary>
        /// <param name="extrinsicstate">
        /// The extrinsicstate.
        /// </param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
}