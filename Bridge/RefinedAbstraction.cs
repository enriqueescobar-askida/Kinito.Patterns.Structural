namespace Bridge
{
    /// <summary>
    /// The refined abstraction.
    /// </summary>
    internal class RefinedAbstraction : Abstraction
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            this.implementor.Operation();
        }
    }
}