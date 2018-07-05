namespace Decorator
{
    using System;

    /// <summary>
    /// The concrete decorator b.
    /// </summary>
    internal class ConcreteDecoratorB : AbstractDecorator
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            base.Operation();
            this.AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        /// <summary>
        /// The added behavior.
        /// </summary>
        private void AddedBehavior()
        {
        }
    }
}