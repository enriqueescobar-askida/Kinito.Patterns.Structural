namespace Decorator
{
    using System;

    internal class Video : AbstractLibraryItem
    {
        private string _director;

        private string _title;

        private int _playTime;

        /// <summary>
        /// Initializes a new instance of the <see cref="Video"/> class.
        /// </summary>
        /// <param name="director">
        /// The director.
        /// </param>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="numCopies">
        /// The num copies.
        /// </param>
        /// <param name="playTime">
        /// The play time.
        /// </param>
        public Video(string director, string title, int numCopies, int playTime)
        {
            this._director = director;
            this._title = title;
            this.NumCopies = numCopies;
            this._playTime = playTime;
        }

        /// <summary>
        /// The display.
        /// </summary>
        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(" Director: {0}", this._director);
            Console.WriteLine(" Title: {0}", this._title);
            Console.WriteLine(" # Copies: {0}", this.NumCopies);
            Console.WriteLine(" Playtime: {0}\n", this._playTime);
        }
    }
}