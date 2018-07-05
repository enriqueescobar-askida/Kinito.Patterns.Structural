namespace FlyWeight
{
    /// <summary>
    /// The abstract flyweight.
    /// </summary>
    internal abstract class AbstractFlyweight
    {
        /// <summary>
        /// The operation.
        /// </summary>
        /// <param name="extrinsicstate">
        /// The extrinsicstate.
        /// </param>
        public abstract void Operation(int extrinsicstate);
    }
}