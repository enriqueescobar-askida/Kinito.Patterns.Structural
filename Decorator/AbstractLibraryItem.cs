namespace Decorator
{
    /// <summary>
    /// The abstract library item.
    /// </summary>
    public abstract class AbstractLibraryItem
    {
        /// <summary>
        /// Gets or sets the num copies.
        /// </summary>
        public int NumCopies { get; set; }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public abstract void Display();
    }
}