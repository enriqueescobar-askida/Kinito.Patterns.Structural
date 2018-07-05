namespace Proxy
{
    using System;

    /// <summary>
    /// The real subject.
    /// </summary>
    public class RealSubject : AbstractSubject
    {
        /// <summary>
        /// The request.
        /// </summary>
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}