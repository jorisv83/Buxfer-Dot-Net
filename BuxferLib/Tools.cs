using System;

namespace BuxferLib
{
    public class Tools
    {
        public static string CleanField(string value)
        {
            return value.Trim().Trim(Environment.NewLine.ToCharArray());
        }
    }
}
