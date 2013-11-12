namespace SubstringForStringBuilder
{
    using System;
    using System.Linq;
    using System.Text;

    //Implement an extension method Substring(int index, int length) for the class StringBuilder 
    //that returns new StringBuilder and has the same functionality as Substring in the class String.

    public class SubstringForStringBuilderClass
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            string preresult = sb.ToString().Substring(index, length);
            StringBuilder result = new StringBuilder();
            result.Append(preresult);
            return result;
        }
    }
}