//-----------------------------------------------------------------------
// <copyright file="Tools.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferLib
{
    using System;
    using System.Globalization;

    /// <summary>
    /// A general class that provides access to helpful methods
    /// </summary>
    public static class Tools
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

        /// <summary>
        /// Retrieves a new french culture info object
        /// </summary>
        /// <returns>A new french culture info instance</returns>
        public static CultureInfo RetrieveCultureInfoFrench()
        {
            return new CultureInfo("fr-FR", true);
        }
    }
}
