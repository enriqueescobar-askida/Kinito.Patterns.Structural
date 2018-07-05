namespace Bridge
{
    using System;
    using System.Collections.Generic;

    internal class CustomersData : AbstractDataObject
    {
        private readonly List<string> _customers = new List<string>();

        private int _current = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersData"/> class.
        /// </summary>
        public CustomersData()
        {
            // Loaded from a database
            this._customers.Add("Jim Jones");
            this._customers.Add("Samual Jackson");
            this._customers.Add("Allen Good");
            this._customers.Add("Ann Stills");
            this._customers.Add("Lisa Giolani");
        }

        /// <summary>
        /// Nexts the record.
        /// </summary>
        public override void NextRecord()
        {
            if (this._current <= this._customers.Count - 1)
            {
                this._current++;
            }
        }

        /// <summary>
        /// Priors the record.
        /// </summary>
        public override void PriorRecord()
        {
            if (this._current > 0)
            {
                this._current--;
            }
        }

        /// <summary>
        /// Adds the record.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public override void AddRecord(string customer)
        {
            this._customers.Add(customer);
        }

        /// <summary>
        /// Deletes the record.
        /// </summary>
        /// <param name="customer">The customer.</param>
        public override void DeleteRecord(string customer)
        {
            this._customers.Remove(customer);
        }

        /// <summary>
        /// Shows the record.
        /// </summary>
        public override void ShowRecord()
        {
            Console.WriteLine(this._customers[this._current]);
        }

        /// <summary>
        /// Shows all records.
        /// </summary>
        public override void ShowAllRecords()
        {
            foreach (string customer in this._customers)
            {
                Console.WriteLine(" " + customer);
            }
        }
    }
}