using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_6
{
    public static class LinqExtensionMethods
    {
        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return (from obj in collection where predicate(obj) == false select obj);
        }

        public static IEnumerable<T> Repeat<T>(this IEnumerable<T> collection, int times)
        {
            for (int i = 0; i < times; i++)
            {
                foreach (T item in collection)
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<string> WhereEndsWith(this IEnumerable<string> collection,
            IEnumerable<string> suffixes)
        {
            foreach (string str in collection)
            {
                foreach (string suff in suffixes)
                {
                    if (str.EndsWith(suff))
                    {
                        yield return str;
                    }
                }
            }
        }

        public static void Test()
        {
            string[] strArray = {"strone", "strtwo", "strthree"};
            IEnumerable<string> strEnum = strArray.WhereNot(str => str == "strtwo");
            Console.WriteLine("String : String after WhereNot with 'strtwo': ");
            printArray(strEnum);
            string[] endings = {"two", "three"};
            strEnum = strArray.WhereEndsWith(endings);
            Console.WriteLine("String After filtering items with endings 'two', 'three':");
            printArray(strEnum);
            strEnum = strArray.Repeat(10);
            Console.WriteLine("String Repeated 10 times :");
            printArray(strEnum);


        }

        public static void printArray<T>(IEnumerable<T> array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
