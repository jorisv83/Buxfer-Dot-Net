//-----------------------------------------------------------------------
// <copyright file="Tools.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferLib
{
    using System;

    /// <summary>
    /// A general class that provides access to helpful methods
    /// </summary>
    public class Tools
    {
        /// <summary>
        /// Clean a string and return it 
        /// </summary>
        /// <param name="value">The string to be cleaned</param>
        /// <returns>The cleaned string</returns>
        public static string CleanField(string value)
        {
            return value.Trim().Trim(Environment.NewLine.ToCharArray());
        }
    }
}
