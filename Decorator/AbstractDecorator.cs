namespace Decorator
{
    /// <summary>
    /// The abstract decorator.
    /// </summary>
    internal abstract class AbstractDecorator : AbstractComponent
    {
        /// <summary>
        /// The component.
        /// </summary>
        protected AbstractComponent Component;

        /// <summary>
        /// Sets the component.
        /// </summary>
        /// <param name="component">The component.</param>
        public void SetComponent(AbstractComponent component)
        {
            this.Component = component;
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            if (this.Component != null)
            {
                this.Component.Operation();
            }
        }
    }
}