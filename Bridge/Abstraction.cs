namespace Bridge
{
    /// <summary>
    /// The abstraction.
    /// </summary>
    internal class Abstraction
    {
        /// <summary>
        /// The implementor.
        /// </summary>
        protected AbstractImplementor implementor;

        /// <summary>
        /// Sets the implementor.
        /// </summary>
        /// <value>
        /// The implementor.
        /// </value>
        public AbstractImplementor Implementor
        {
            set { this.implementor = value; }
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public virtual void Operation()
        {
            this.implementor.Operation();
        }
    }
}