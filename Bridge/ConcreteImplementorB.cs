namespace Bridge
{
    using System;

    /// <summary>
    /// The concrete implementor b.
    /// </summary>
    public class ConcreteImplementorB : AbstractImplementor
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}