namespace Proxy
{
    /// <summary>
    /// The math proxy.
    /// </summary>
    public class MathProxy : IMath
    {
        /// <summary>
        /// The math.
        /// </summary>
        private readonly Math math = new Math();

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
        public double Add(double x, double y)
        {
            return this.math.Add(x, y);
        }

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
        public double Sub(double x, double y)
        {
            return this.math.Sub(x, y);
        }

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
        public double Mul(double x, double y)
        {
            return this.math.Mul(x, y);
        }

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
        public double Div(double x, double y)
        {
            return this.math.Div(x, y);
        }
    }
}