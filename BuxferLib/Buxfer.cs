using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml;
using BuxferLib.BuxferObjects;

namespace BuxferLib
{
    public class Buxfer : IDisposable
    {
        private string loginToken = string.Empty;
        private string baseUrl = "https://www.buxfer.com/api/";
        private WebClient serviceClient;
        public List<Message> Messages = new List<Message>();

        /// <summary>
        /// Create the buxfer interface
        /// </summary>
        /// <param name="username">Your buxfer username</param>
        /// <param name="password">Your buxfer password</param>
        public Buxfer(string username, string password)
        {
            try
            {
                this.serviceClient = new WebClient();
                //this.serviceClient.Credentials = new NetworkCredential(username, password);
                string loginResponse = this.GetResponse(string.Concat("login.xml?userid=", username, "&password=", password));
                Login login = XMLSerializer.DeserializeObject<Login>(loginResponse);
                if (login.Status.ToUpper() == "OK")
                {
                    this.loginToken = login.Token;
                    Messages.Add(new Message() { Date = DateTime.Now, Text = "Login SUCCESS for user: " + username });
                }
                else
                {
                    this.loginToken = string.Empty;
                    Messages.Add(new Message() { Date = DateTime.Now, Text = "Login FAILED for user: " + username + "\nStatus was: " + login.Status });
                }
            }
            catch (Exception ex)
            {
                this.loginToken = string.Empty;
                Messages.Add(new Message() { Date = DateTime.Now, Text = "Login FAILED for user: " + username + "\nException: " + ex.Message });
            }
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = new List<Account>();
            string accountResponse = GetResponse("accounts.xml?token=" + this.loginToken);
            XmlDocument xmlDoc = TranslateStringToXmlDoc(accountResponse);
            foreach (XmlElement e in xmlDoc.SelectNodes("/response/accounts/account"))
            {
                accounts.Add(
                    XMLSerializer.DeserializeObject<Account>(string.Concat("<account>", e.InnerXml, "</account>"))
                    );
            }
            return accounts;
        }

        public void GetTransactions(string accountId)
        {
            string accountResponse = GetResponse("transactions.xml?token=" + this.loginToken + "&accountId=" + accountId );

        }

        ~Buxfer()
        {
            // Finalizer calls Dispose(false)
            Dispose(false);
        }

        private string GetResponse(string urlPart)
        {
            this.serviceClient.Headers["Content-type"] = "text/xml";
            return this.serviceClient.DownloadString(new Uri(string.Concat(this.baseUrl, urlPart)));
        }

        private string PostResponse(string urlPart, string data)
        {
            this.serviceClient.Headers["Content-type"] = "text/xml";
            return this.serviceClient.UploadString(new Uri(string.Concat(this.baseUrl, urlPart)), "POST", data);
        }

        private XmlDocument TranslateStringToXmlDoc(string xml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            return xmlDoc;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

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
    }
}
