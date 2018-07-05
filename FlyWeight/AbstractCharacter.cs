namespace FlyWeight
{
    /// <summary>
    /// The abstract character.
    /// </summary>
    public abstract class AbstractCharacter
    {
        /// <summary>
        /// Gets the symbol.
        /// </summary>
        public char Symbol { get; internal set; }

        /// <summary>
        /// Gets the width.
        /// </summary>
        public int Width { get; internal set; }

        /// <summary>
        /// Gets the height.
        /// </summary>
        public int Height { get; internal set; }

        /// <summary>
        /// Gets the ascent.
        /// </summary>
        public int Ascent { get; internal set; }

        /// <summary>
        /// Gets the descent.
        /// </summary>
        public int Descent { get; internal set; }

        /// <summary>
        /// Gets the point size.
        /// </summary>
        public int PointSize { get; internal set; }

        /// <summary>
        /// The display.
        /// </summary>
        /// <param name="pointSize">
        /// The point size.
        /// </param>
        public abstract void Display(int pointSize);
    }
}