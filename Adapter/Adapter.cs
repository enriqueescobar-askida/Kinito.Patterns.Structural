namespace Adapter
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class Adapter : Target
    {
        /// <summary>
        /// The adaptee.
        /// </summary>
        private readonly Adaptee adaptee = new Adaptee();

        /// <summary>
        /// Requests this instance.
        /// </summary>
        public override void Request()
        {
            // Possibly do some other work
            //  and then call SpecificRequest
            this.adaptee.SpecificRequest();
        }
    }
}