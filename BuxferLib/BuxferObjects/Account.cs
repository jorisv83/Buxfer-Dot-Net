//-----------------------------------------------------------------------
// <copyright file="Account.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferLib
{
    using System;
    using System.Globalization;
    using System.Xml.Serialization;

    /// <summary>
    /// A Buxfer account
    /// </summary>
    [XmlRoot("account")]
    public class Account : IEquatable<Account>
    {
        /// <summary>
        /// The Id of this account
        /// </summary>
        private string id;

        /// <summary>
        /// THe name of this account
        /// </summary>
        private string name;

        /// <summary>
        /// The bank name of this account
        /// </summary>
        private string bank;

        /// <summary>
        /// The current balance on this account
        /// </summary>
        private double balance;

        /// <summary>
        /// The last time this account was synchronized
        /// </summary>
        private DateTime lastSync;

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class
        /// </summary>
        public Account()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class
        /// </summary>
        /// <param name="id">The id of this account</param>
        /// <param name="name">The name of this account</param>
        public Account(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the id of this account
        /// </summary>
        [XmlElement("id")]
        public string Id
        {
            get { return this.id; }
            set { this.id = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the name of this account
        /// </summary>
        [XmlElement("name")]
        public string Name
        {
            get { return this.name; }
            set { this.name = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the bank name of this account
        /// </summary>
        [XmlElement("bank")]
        public string Bank
        {
            get { return this.bank; }
            set { this.bank = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the current balance of this account
        /// </summary>
        [XmlElement("balance")]
        public double Balance
        {
            get { return this.balance; }
            set { this.balance = double.Parse(Tools.CleanField(value.ToString(Tools.RetrieveCultureInfoFrench())), Tools.RetrieveCultureInfoFrench()); }
        }

        /// <summary>
        /// Gets or sets the time this account was last synchronized
        /// </summary>
        [XmlElement("lastSynced")]
        public DateTime LastSync
        {
            get { return this.lastSync; }
            set { this.lastSync = value; }
        }

        /// <summary>
        /// Compare this to another account instance and return true if both are equal
        /// </summary>
        /// <param name="other">The other instance to compare to</param>
        /// <returns>True if equal</returns>
        public bool Equals(Account other)
        {
            return this.id == other.Id;
        }
    }
}
