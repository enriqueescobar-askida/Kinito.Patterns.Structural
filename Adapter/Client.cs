namespace Adapter
{
    using System;

    /// <summary>
    /// The client.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        public Client()
        {
            // Create adapter and place a request
            Target target = new Adapter();
            target.Request();

            // Wait for user
            Console.ReadKey();
        }
    }
}
