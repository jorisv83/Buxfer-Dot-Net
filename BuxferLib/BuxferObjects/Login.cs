
using System;
using System.Xml.Serialization;
namespace BuxferLib.BuxferObjects
{
    /// <summary>
    /// Response object for the login call
    /// </summary>
    [XmlRoot("response")]
    public class Login
    {
        private string status;
        private string token;
        private string userId;
        private string requestId;

        [XmlElement("status")]
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = Tools.CleanField(value);
            }
        }

        [XmlElement("token")]
        public string Token
        {
            get
            {
                return token;
            }
            set
            {
                token = Tools.CleanField(value);
            }
        }

        [XmlElement("uid")]
        public string UserId
        {
            get
            {
                return userId;
            }
            set
            {
                userId = Tools.CleanField(value);
            }
        }

        [XmlElement("request_id")]
        public string RequestId
        {
            get
            {
                return requestId;
            }
            set
            {
                requestId = Tools.CleanField(value);
            }
        }

        public Login()
        {

        }
    }
}
