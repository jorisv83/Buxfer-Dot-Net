//-----------------------------------------------------------------------
// <copyright file="Logon.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferLib.BuxferObjects
{
    using System;
    using System.Xml.Serialization;

    /// <summary>
    /// Response object for the login call
    /// </summary>
    [XmlRoot("response")]
    public class Logon
    {
        /// <summary>
        /// THe status of the request, OK or Error
        /// </summary>
        private string status;

        /// <summary>
        /// The token to use in all other requests
        /// </summary>
        private string token;

        /// <summary>
        /// The user identification number
        /// </summary>
        private string userId;

        /// <summary>
        /// The request identification
        /// </summary>
        private string requestId;

        /// <summary>
        /// Initializes a new instance of the <see cref="Logon" /> class
        /// </summary>
        public Logon()
        {
        }

        /// <summary>
        /// Gets or sets the status
        /// </summary>
        [XmlElement("status")]
        public string Status
        {
            get { return this.status; }
            set { this.status = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the token to use in other requests
        /// </summary>
        [XmlElement("token")]
        public string Token
        {
            get { return this.token; }
            set { this.token = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the user identification
        /// </summary>
        [XmlElement("uid")]
        public string UserId
        {
            get { return this.userId; }
            set { this.userId = Tools.CleanField(value); }
        }

        /// <summary>
        /// Gets or sets the request identification
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId
        {
            get { return this.requestId; }
            set { this.requestId = Tools.CleanField(value); }
        }
    }
}
