namespace FlyWeight
{
    using System.Collections;

    /// <summary>
    /// The flyweight factory.
    /// </summary>
    internal class FlyweightFactory
    {
        /// <summary>
        /// The flyweights.
        /// </summary>
        private readonly Hashtable flyweights = new Hashtable();

        /// <summary>
        /// Initializes a new instance of the <see cref="FlyweightFactory"/> class.
        /// </summary>
        public FlyweightFactory()
        {
            this.flyweights.Add("X", new ConcreteFlyweight());
            this.flyweights.Add("Y", new ConcreteFlyweight());
            this.flyweights.Add("Z", new ConcreteFlyweight());
        }

        /// <summary>
        /// The get flyweight.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="AbstractFlyweight"/>.
        /// </returns>
        public AbstractFlyweight GetFlyweight(string key)
        {
            return (AbstractFlyweight)this.flyweights[key];
        }
    }
}