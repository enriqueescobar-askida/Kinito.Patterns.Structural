namespace Proxy
{
    /// <summary>
    /// The proxy.
    /// </summary>
    public class Proxy : AbstractSubject
    {
        /// <summary>
        /// Gets the real subject.
        /// </summary>
        public RealSubject RealSubject { get; internal set; }

        /// <summary>
        /// The request.
        /// </summary>
        public override void Request()
        {
            if (this.RealSubject == null) this.RealSubject = new RealSubject();

            this.RealSubject.Request();
        }
    }
}