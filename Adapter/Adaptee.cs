namespace Adapter
{
    using System;

    /// <summary>
    /// The adaptee.
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// Specifics the request.
        /// </summary>
        public void SpecificRequest()
        {
            Console.WriteLine("Called SpecificRequest()");
        }
    }
}