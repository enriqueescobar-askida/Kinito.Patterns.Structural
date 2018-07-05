namespace Bridge
{
    using System;

    /// <summary>
    /// The customers base.
    /// </summary>
    public class CustomersBase
    {
        /// <summary>
        /// The group.
        /// </summary>
        protected string Group;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersBase"/> class.
        /// </summary>
        /// <param name="group">The group.</param>
        public CustomersBase(string group)
        {
            this.Group = group;
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public AbstractDataObject Data { get; set; }

        /// <summary>
        /// Nexts this instance.
        /// </summary>
        public virtual void Next()
        {
            this.Data.NextRecord();
        }

        /// <summary>
        /// Priors this instance.
        /// </summary>
        public virtual void Prior()
        {
            this.Data.PriorRecord();
        }

        /// <summary>
        /// Adds the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public virtual void Add(string customer)
        {
            this.Data.AddRecord(customer);
        }

        /// <summary>
        /// Deletes the specified customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public virtual void Delete(string customer)
        {
            this.Data.DeleteRecord(customer);
        }

        /// <summary>
        /// Shows this instance.
        /// </summary>
        public virtual void Show()
        {
            this.Data.ShowRecord();
        }

        /// <summary>
        /// Shows all.
        /// </summary>
        public virtual void ShowAll()
        {
            Console.WriteLine("Customer Group: " + this.Group);
            this.Data.ShowAllRecords();
        }
    }
}