namespace FlyWeight
{
    using System;

    /// <summary>
    /// The character b.
    /// </summary>
    public class CharacterB : AbstractCharacter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterB"/> class.
        /// </summary>
        public CharacterB()
        {
            this.Symbol = 'B';
            this.Height = 100;
            this.Width = 140;
            this.Ascent = 72;
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