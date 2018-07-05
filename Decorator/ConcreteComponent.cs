namespace Decorator
{
    using System;

    /// <summary>
    /// The concrete component.
    /// </summary>
    internal class ConcreteComponent : AbstractComponent
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}