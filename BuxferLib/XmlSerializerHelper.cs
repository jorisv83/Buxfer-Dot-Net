//-----------------------------------------------------------------------
// <copyright file="XmlSerializerHelper.cs" company="Jorisv83">
//     Copyright (c) Jorisv83. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace BuxferLib
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    /// <summary>
    /// Class that wraps XML serialization functions into 2 methods
    /// </summary>
    public static class XmlSerializerHelper
    {
        /// <summary>
        /// Serialize an object into an XML string
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize</typeparam>
        /// <param name="obj">The object itself</param>
        /// <param name="xmlWriter">A reference to an XML writer instance</param>
        public static void SerializeObject<T>(T obj, ref XmlWriter xmlWriter)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();

            xmlSerializerNamespaces.Add(string.Empty, string.Empty);
            xs.Serialize(xmlWriter, obj, xmlSerializerNamespaces);
        }

        /// <summary>
        /// Serialize an object into an XML string
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize</typeparam>
        /// <param name="obj">The object itself</param>
        /// <returns>A string containing the XML representation of the object</returns>
        public static string SerializeObject<T>(T obj)
        {
            string xmlString = string.Empty;
            MemoryStream memoryStream = new MemoryStream();
            XmlSerializer xs = new XmlSerializer(typeof(T));
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            xs.Serialize(xmlTextWriter, obj);
            memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
            xmlString = UTF8ByteArrayToString(memoryStream.ToArray());
            return xmlString;
        }

        /// <summary>
        /// Reconstruct an object from an XML string
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize</typeparam>
        /// <param name="xml">A string containing the XML representation of the object</param>
        /// <returns>An object of the given type filled with the values present in the given XML string</returns>
        public static T DeserializeObject<T>(string xml)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream(StringToUTF8ByteArray(xml));
            return (T)xs.Deserialize(memoryStream);
        }

        /// <summary>
        /// To convert a Byte Array of Unicode values (UTF-8 encoded) to a complete String.
        /// </summary>
        /// <param name="characters">Unicode Byte Array to be converted to String</param>
        /// <returns>String converted from Unicode Byte Array</returns>
        private static string UTF8ByteArrayToString(byte[] characters)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            return encoding.GetString(characters);
        }

        /// <summary>
        /// Converts the String to UTF8 Byte array and is used in De serialization
        /// </summary>
        /// <param name="xmlString">The string to convert</param>
        /// <returns>A byte array</returns>
        private static byte[] StringToUTF8ByteArray(string xmlString)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            return encoding.GetBytes(xmlString);
        }
    }
}
