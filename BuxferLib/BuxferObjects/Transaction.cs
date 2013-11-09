using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BuxferLib.BuxferObjects
{
    [XmlRoot("transaction")]
    public class Transaction
    {
        private string id;
        private string description;
        private string date;
        private string type;
        private double amount;
        private string accountId;
        private string tags;
        private string extraInfo;

        [XmlElement("id")]
        public string Id
        {
            get { return id; }
            set { id = Tools.CleanField(value); }
        }

        [XmlElement("description")]
        public string Description
        {
            get { return description; }
            set { description = Tools.CleanField(value); }
        }

        [XmlElement("date")]
        public string Date
        {
            get { return date; }
            set { date = Tools.CleanField(value); }
        }

        [XmlElement("type")]
        public string Type
        {
            get { return type; }
            set { type = Tools.CleanField(value); }
        }

        [XmlElement("amount")]
        public double Amount
        {
            get { return amount; }
            set { amount = double.Parse(Tools.CleanField(value.ToString())); }
        }

        [XmlElement("accountId")]
        public string AccountId
        {
            get { return accountId; }
            set { accountId = Tools.CleanField(value); }
        }

        [XmlElement("tags")]
        public string Tags
        {
            get { return tags; }
            set { tags = Tools.CleanField(value); }
        }

        [XmlElement("extraInfo")]
        public string ExtraInfo
        {
            get { return extraInfo; }
            set { extraInfo = Tools.CleanField(value); }
        }

        public Transaction()
        {

        }
    }
}
