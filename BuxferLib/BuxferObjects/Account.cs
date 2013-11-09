using System;
using System.Xml.Serialization;

namespace BuxferLib.BuxferObjects
{
    /// <summary>
    /// A buxfer account
    /// </summary>
    [XmlRoot("account")]
    public class Account
    {
        private string id;
        private string name;
        private string bank;
        private double balance;
        //private DateTime lastSync;

        [XmlElement("id")]
        public string Id
        {
            get { return id; }
            set { id = Tools.CleanField(value); }
        }

        [XmlElement("name")]
        public string Name
        {
            get { return name; }
            set { name = Tools.CleanField(value); }
        }

        [XmlElement("bank")]
        public string Bank
        {
            get { return bank; }
            set { bank = Tools.CleanField(value); }
        }

        [XmlElement("balance")]
        public double Balance
        {
            get { return balance; }
            set { balance = double.Parse(Tools.CleanField(value.ToString())); }
        }

        /*[XmlElement("lastSynced")]
        public DateTime LastSync
        {
            get { return lastSync; }
            set { lastSync = value; }
        }*/

        public Account()
        {

        }

        public Account(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
