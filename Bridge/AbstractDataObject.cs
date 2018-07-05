namespace Bridge
{
    /// <summary>
    /// The abstract data object.
    /// </summary>
    public abstract class AbstractDataObject
    {
        /// <summary>
        /// Nexts the record.
        /// </summary>
        public abstract void NextRecord();

        /// <summary>
        /// Priors the record.
        /// </summary>
        public abstract void PriorRecord();

        /// <summary>
        /// Adds the record.
        /// </summary>
        /// <param name="name">The name.</param>
        public abstract void AddRecord(string name);

        /// <summary>
        /// Deletes the record.
        /// </summary>
        /// <param name="name">The name.</param>
        public abstract void DeleteRecord(string name);

        /// <summary>
        /// Shows the record.
        /// </summary>
        public abstract void ShowRecord();

        /// <summary>
        /// Shows all records.
        /// </summary>
        public abstract void ShowAllRecords();
    }
}