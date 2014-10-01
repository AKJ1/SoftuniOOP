using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder stb, int start, int length)
        {
            //The easy way
            return stb.ToString().Substring(start, length);
            
            //The long way
            //char[] substr = new char[length];
            //int counter = 0;
            //for (int i = start; i < length; i++, counter++)
            //{
            //    substr[counter] = stb[i];
            //}
            //return new string(substr);
        }

        public static void RemoveText(this StringBuilder stb, string text)
        {
            //The easy way
            Regex rgx = new Regex(@text , RegexOptions.IgnoreCase);
            string str = rgx.Replace(stb.ToString(), "");
            stb.Clear();
            stb.Append(str);

            //The long way
            //for (int i = 0; i < stb.Length; i++)
            //{
            //    bool available = true;
            //    string check = default(string);
            //    for (int j = 0; j < text.Length; j++)
            //    {
            //        if (text[j] != stb[i + j])
            //        {
            //            available = false;
            //            break;  
            //        }
            //    }
            //    if (available)
            //    {
            //        for (int j = 0; j < text.Length; j++)
            //        {
            //            modifiedSB[i + j] = default(char);
            //        }
            //    }
            //}
        }

        public static void AppendAll<T>(this StringBuilder stb, IEnumerable<T> items)
        {
            items.ToList().ForEach(i => stb.Append(i.ToString()));
            //foreach (T item in items)
            //{
            //    stb.Append(item.ToString());
            //}
        }

        public static void Test()
        {
            Console.WriteLine("The string we start with is 'TenLetters'");
            StringBuilder sb = new StringBuilder("TenLetters");
            string str = sb.Substring(4,5);
            Console.WriteLine("Getting a substring that starts at 4 and continues for 5 : {0}", str);
            sb.RemoveText("letter");
            Console.WriteLine("Removing 'Letter' {0}", sb.ToString());
            string[] toAppend = {"Firstthing","secondthing","thirdthing"};
            sb.AppendAll(toAppend);
            Console.WriteLine("After appending an array of things : {0}", sb);
        }
    }
}
