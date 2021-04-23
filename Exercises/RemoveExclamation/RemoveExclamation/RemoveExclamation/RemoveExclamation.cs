using System;
using System.Text;

namespace RemoveExclamation
{
    public class Remove
    {
        public static string RemoveLastExclamationMark(string input)
        {
            //Remove a exclamation mark from the end of string.
            var output = new StringBuilder();
            return input[input.Length - 1] != '!' ? output.Replace('!','') :  ;

        }
    }
}
