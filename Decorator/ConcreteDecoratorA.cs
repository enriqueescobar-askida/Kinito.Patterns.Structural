namespace Decorator
{
    using System;

    /// <summary>
    /// The concrete decorator a.
    /// </summary>
    internal class ConcreteDecoratorA : AbstractDecorator
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}