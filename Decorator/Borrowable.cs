namespace Decorator
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The borrowable.
    /// </summary>
    public class Borrowable : AbstractLibraryDecorator
    {
        /// <summary>
        /// The borrowers.
        /// </summary>
        protected List<string> BorrowerList = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Borrowable"/> class.
        /// </summary>
        /// <param name="libraryItem">
        /// The library item.
        /// </param>
        public Borrowable(AbstractLibraryItem libraryItem) : base(libraryItem)
        {
        }

        /// <summary>
        /// The borrow item.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public void BorrowItem(string name)
        {
            this.BorrowerList.Add(name);
            this.LibraryItem.NumCopies--;
        }

        /// <summary>
        /// The return item.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        public void ReturnItem(string name)
        {
            this.BorrowerList.Remove(name);
            this.LibraryItem.NumCopies++;
        }

        /// <summary>
        /// The display.
        /// </summary>
        public override void Display()
        {
            base.Display();

            foreach (string borrower in this.BorrowerList)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}