namespace Proxy
{
    /// <summary>
    /// The Math interface.
    /// </summary>
    public interface IMath
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
        double Add(double x, double y);

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
        double Sub(double x, double y);

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
        double Mul(double x, double y);

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
        double Div(double x, double y);
    }
}