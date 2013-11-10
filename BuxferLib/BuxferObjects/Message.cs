//-----------------------------------------------------------------------
// <copyright file="Message.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferLib.BuxferObjects
{
    using System;

    /// <summary>
    /// Class that represents a message. These can be error messages but also info or warning messages.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class
        /// </summary>
        /// <param name="type">The category of this message</param>
        /// <param name="date">When did this message occur</param>
        /// <param name="text">The message text that gives more information about this message</param>
        public Message(Category type, DateTime date, string text)
        {
            this.Type = type;
            this.Date = date;
            this.Text = text;
        }

        /// <summary>
        /// The category that messages can have
        /// </summary>
        public enum Category
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
        /// Gets or sets the message type
        /// </summary>
        public Category Type { get; set; }

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
