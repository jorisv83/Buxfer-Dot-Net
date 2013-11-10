//-----------------------------------------------------------------------
// <copyright file="Message.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferLib
{
    using System;

    /// <summary>
    /// The category that messages can have
    /// </summary>
    public enum MessageCategory
    {
        /// <summary>
        /// An error message
        /// </summary>
        Error,

        /// <summary>
        /// A warning message
        /// </summary>
        Warning,

        /// <summary>
        /// An informative message
        /// </summary>
        Info
    }

    /// <summary>
    /// Class that represents a message. These can be error messages but also info or warning messages.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class
        /// </summary>
        /// <param name="category">The category of this message</param>
        /// <param name="date">When did this message occur</param>
        /// <param name="text">The message text that gives more information about this message</param>
        public Message(MessageCategory category, DateTime date, string text)
        {
            this.Category = category;
            this.Date = date;
            this.Text = text;
        }        

        /// <summary>
        /// Gets or sets the message type
        /// </summary>
        public MessageCategory Category { get; set; }

        /// <summary>
        /// Gets or sets the date and time this message occurred
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the message text
        /// </summary>
        public string Text { get; set; }
    }
}
