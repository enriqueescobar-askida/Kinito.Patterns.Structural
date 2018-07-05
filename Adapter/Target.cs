namespace Adapter
{
    using System;

    /// <summary>
    /// The 'Target' class
    /// </summary>
    public abstract class Target
    {
        /// <summary>
        /// Requests this instance.
        /// </summary>
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}