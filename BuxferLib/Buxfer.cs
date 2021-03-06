﻿//-----------------------------------------------------------------------
// <copyright file="Buxfer.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
using System;

[assembly: CLSCompliant(true)]

namespace BuxferLib
{
    using System.Collections.ObjectModel;
    using System.Net;
    using System.Web;
    using System.Xml;

    /// <summary>
    /// Main class to govern Buxfer functions
    /// </summary>
    public class Buxfer : IDisposable
    {
        /// <summary>
        /// The token to use in all buxfer requests
        /// </summary>
        private string loginToken = string.Empty;

        /// <summary>
        /// The base url appended to all the requests
        /// </summary>
        private string baseUrl = "https://www.buxfer.com/api/";

        /// <summary>
        /// A web client to execute the requests to the Buxfer API
        /// </summary>
        private WebClient serviceClient;

        /// <summary>
        /// Error or other messages list
        /// </summary>
        private Collection<Message> messages = new Collection<Message>();

        /// <summary>
        /// Indicates if the logon has been successful
        /// </summary>
        private bool logOnOk = false;

        /// <summary>
        /// Initializes a new instance of the <see cref="Buxfer" /> class
        /// </summary>
        /// <param name="userName">Your buxfer username</param>
        /// <param name="password">Your buxfer password</param>
        public Buxfer(string userName, string password)
        {
            try
            {
                this.serviceClient = new WebClient();

                string loginResponse = this.GetResponse(string.Concat("login.xml?userid=", userName, "&password=", password));
                LogOn login = XmlSerializerHelper.DeserializeObject<LogOn>(loginResponse);
                if (login.Status.ToUpper(Tools.RetrieveCultureInfoFrench()) == "OK")
                {
                    this.logOnOk = true;
                    this.loginToken = login.Token;
                    this.messages.Add(new Message(MessageCategory.Info, DateTime.Now, "Login SUCCESS for user: " + userName));
                }
                else
                {
                    this.loginToken = string.Empty;
                    this.messages.Add(new Message(MessageCategory.Error, DateTime.Now, "Login FAILED for user: " + userName + "\nStatus was: " + login.Status));
                }
            }
            catch (WebException ex)
            {
                this.loginToken = string.Empty;
                this.messages.Add(new Message(MessageCategory.Error, DateTime.Now, "Login FAILED for user: " + userName + "\nException: " + ex.Message));
            }
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="Buxfer" /> class
        /// </summary>
        ~Buxfer()
        {
            // Finalizer calls Dispose(false)
            this.Dispose(false);
        }

        /// <summary>
        /// Gets a value indicating whether the logon has been successful
        /// </summary>
        public bool LogOnOk
        {
            get { return this.logOnOk; }
        }

        /// <summary>
        /// Gets the messages list containing errors and other messages
        /// </summary>
        public Collection<Message> Messages
        {
            get { return this.messages; }
        }

        /// <summary>
        /// Return a list of all accounts
        /// </summary>
        /// <returns>List of accounts</returns>
        public Collection<Account> RetrieveAllAccounts()
        {
            Collection<Account> accounts = new Collection<Account>();
            string accountResponse = this.GetResponse("accounts.xml?token=" + this.loginToken);
            XmlDocument xmlDoc = TranslateStringToXmlDoc(accountResponse);
            foreach (XmlElement e in xmlDoc.SelectNodes("/response/accounts/account"))
            {
                accounts.Add(XmlSerializerHelper.DeserializeObject<Account>(string.Concat("<account>", e.InnerXml, "</account>")));
            }

            return accounts;
        }

        /// <summary>
        /// Search for a specific account
        /// </summary>
        /// <param name="accountId">The account id to look for</param>
        /// <returns>An accounts</returns>
        public Account RetrieveAccount(string accountId)
        {
            foreach (Account a in this.RetrieveAllAccounts())
            {
                if (a.Id == accountId)
                {
                    return a;
                }
            }

            return null;
        }

        /// <summary>
        /// Return a list of all transactions from a given account and an optional page
        /// </summary>
        /// <param name="accountId">The account to retrieve the transactions for</param>
        /// <param name="page">The page number, only 25 transactions per page are returned</param>
        /// <returns>A list of transactions</returns>
        public Collection<Transaction> RetrieveAllTransactionsFromAccount(string accountId, string page)
        {
            Collection<Transaction> transactions = new Collection<Transaction>();
            string transactionResponse = this.GetResponse("transactions.xml?token=" + this.loginToken + "&accountId=" + accountId + "&page=" + page);
            XmlDocument xmlDoc = TranslateStringToXmlDoc(transactionResponse);
            foreach (XmlElement e in xmlDoc.SelectNodes("/response/transactions/transaction"))
            {
                transactions.Add(XmlSerializerHelper.DeserializeObject<Transaction>(string.Concat("<transaction>", e.InnerXml, "</transaction>")));
            }

            return transactions;
        }

        /// <summary>
        /// Return a list of all transactions from a given account and an optional page
        /// </summary>
        /// <param name="accountId">The account to retrieve the transactions for</param>
        /// <returns>A list of transactions</returns>
        public Collection<Transaction> RetrieveAllTransactionsFromAccount(string accountId)
        {
            return this.RetrieveAllTransactionsFromAccount(accountId, "1");
        }

        /// <summary>
        /// Add a transaction to Buxfer
        /// </summary>
        /// <param name="transaction">The transaction to add</param>
        public void AddTransaction(Transaction transaction)
        {
            //DESCRIPTION [+]AMOUNT [TAGS:<tags>] [ACCT:<accounts>] [DATE:<date>] [STATUS:<status>]

            string postData = string.Concat("format=sms&text=",
                transaction.Description, " ", "+",transaction.Amount.ToString(Tools.RetrieveCultureInfoFrench()),
                //" TAGS:", transaction.Tags,
                " acct:", transaction.AccountId,
                "&token=" + this.loginToken
                );
            //" DATE:", transaction.Date);
            string response = this.PostResponse("add_transaction.json", HttpUtility.UrlEncode(postData));
        }

        /// <summary>
        /// Dispose this object
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Dispose this object
        /// </summary>
        /// <param name="disposing">Should the managed resources be disposed</param>
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources
                if (this.serviceClient != null)
                {
                    this.serviceClient.Dispose();
                    this.serviceClient = null;
                }
            }
        }

        /// <summary>
        /// Convert an string containing an xml document to an xml document type
        /// </summary>
        /// <param name="xml">The string containing xml</param>
        /// <returns>An xml document</returns>
        private static XmlDocument TranslateStringToXmlDoc(string xml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            return xmlDoc;
        }

        /// <summary>
        /// Use the web client to get a response from the base url combined with the url part parameter
        /// </summary>
        /// <param name="urlPart">The part to add to the base url for this request</param>
        /// <returns>The response</returns>
        private string GetResponse(string urlPart)
        {
            this.serviceClient.Headers["Content-type"] = "text/xml";
            return this.serviceClient.DownloadString(new Uri(string.Concat(this.baseUrl, urlPart)));
        }

        /// <summary>
        /// Post data using the web client to the base url combined with the url part parameter
        /// </summary>
        /// <param name="urlPart">The part to add to the base url for this request</param>
        /// <param name="data">The data to post</param>
        /// <returns>The response</returns>
        private string PostResponse(string urlPart, string data)
        {
            //this.serviceClient.Headers["Content-type"] = "text/xml";
            return this.serviceClient.UploadString(new Uri(string.Concat(this.baseUrl, urlPart)), "POST", data);
        }
    }
}
