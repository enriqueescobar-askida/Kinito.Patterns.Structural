namespace FlyWeight
{
    using System;

    /// <summary>
    /// The character z.
    /// </summary>
    public class CharacterZ : AbstractCharacter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterZ"/> class.
        /// </summary>
        public CharacterZ()
        {
            this.Symbol = 'Z';
            this.Height = 100;
            this.Width = 100;
            this.Ascent = 68;
            this.Descent = 0;
        }

        /// <summary>
        /// The display.
        /// </summary>
        /// <param name="pointSize">
        /// The point size.
        /// </param>
        public override void Display(int pointSize)
        {
            this.PointSize = pointSize;
            Console.WriteLine(this.Symbol + " (pointsize " + this.PointSize + ")");
        }
    }
}