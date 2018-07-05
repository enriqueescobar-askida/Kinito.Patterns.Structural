namespace Decorator
{
    public class AbstractLibraryDecorator : AbstractLibraryItem
    {
        /// <summary>
        /// The library item.
        /// </summary>
        protected AbstractLibraryItem LibraryItem;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractDecorator"/> class.
        /// </summary>
        /// <param name="libraryItem">The library item.</param>
        public AbstractLibraryDecorator(AbstractLibraryItem libraryItem)
        {
            this.LibraryItem = libraryItem;
        }

        /// <summary>
        /// Displays this instance.
        /// </summary>
        public override void Display()
        {
            this.LibraryItem.Display();
        }
    }
}