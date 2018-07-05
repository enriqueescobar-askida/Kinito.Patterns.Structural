namespace Proxy
{
    /// <summary>
    /// The math.
    /// </summary>
    public class Math : IMath
    {
        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double Add(double x, double y) { return x + y; }

        /// <summary>
        /// The sub.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double Sub(double x, double y) { return x - y; }

        /// <summary>
        /// The mul.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double Mul(double x, double y) { return x * y; }

        /// <summary>
        /// The div.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public double Div(double x, double y) { return x / y; }
    }
}