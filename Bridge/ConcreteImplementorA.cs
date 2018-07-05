namespace Bridge
{
    using System;

    /// <summary>
    /// The concrete implementor a.
    /// </summary>
    internal class ConcreteImplementorA : AbstractImplementor
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}