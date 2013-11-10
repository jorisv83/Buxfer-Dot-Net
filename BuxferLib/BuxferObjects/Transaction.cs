//-----------------------------------------------------------------------
// <copyright file="Transaction.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferLib.BuxferObjects
{
    using System.Xml.Serialization;

    /// <summary>
    /// A class that represents a Buxfer transaction
    /// </summary>
    [XmlRoot("transaction")]
    public class Transaction
    {
        /// <summary>
        /// The identification number of a transaction
        /// </summary>
        private string id;

        /// <summary>
        /// The description of a transaction
        /// </summary>
        private string description;

        /// <summary>
        /// The date on which this transaction occurred
        /// </summary>
        private string date;

        /// <summary>
        /// The type of this transaction (ex. income, expense, ...)
        /// </summary>
        private string type;

        /// <summary>
        /// The amount of this transaction
        /// </summary>
        private double amount;

        /// <summary>
        /// The account identification this transaction is linked to
        /// </summary>
        private string accountId;

        /// <summary>
        /// Optional tags this transaction has
        /// </summary>
        private string tags;

        /// <summary>
        /// Optional extra information about this transaction
        /// </summary>
        private string extraInfo;

        /// <summary>
        /// Initializes a new instance of the <see cref="Transaction" /> class
        /// </summary>
        public Transaction()
        {
        }

        /// <summary>
        /// Gets or sets the transaction identification number
        /// </summary>
        [XmlElement("id")]
        public string Id
        {
            get { return this.id; }
            set { this.id = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the transaction description
        /// </summary>
        [XmlElement("description")]
        public string Description
        {
            get { return this.description; }
            set { this.description = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the date on which this transaction occurred
        /// </summary>
        [XmlElement("date")]
        public string Date
        {
            get { return this.date; }
            set { this.date = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the type of this transaction (ex. income, expense, ...)
        /// </summary>
        [XmlElement("type")]
        public string Type
        {
            get { return this.type; }
            set { this.type = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the amount of this transaction
        /// </summary>
        [XmlElement("amount")]
        public double Amount
        {
            get { return this.amount; }
            set { this.amount = double.Parse(Tools.CleanField(value.ToString())); }
        }

        /// <summary>
        /// Gets or sets the account identification this transaction is linked to
        /// </summary>
        [XmlElement("accountId")]
        public string AccountId
        {
            get { return this.accountId; }
            set { this.accountId = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the tags of this transaction
        /// </summary>
        [XmlElement("tags")]
        public string Tags
        {
            get { return this.tags; }
            set { this.tags = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets extra information of this transaction
        /// </summary>
        [XmlElement("extraInfo")]
        public string ExtraInfo
        {
            get { return this.extraInfo; }
            set { this.extraInfo = Tools.CleanField(value); }
        }
    }
}
