namespace FlyWeight
{
    using System;

    /// <summary>
    /// The character a.
    /// </summary>
    public class CharacterA : AbstractCharacter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterA"/> class.
        /// </summary>
        public CharacterA()
        {
            this.Symbol = 'A';
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