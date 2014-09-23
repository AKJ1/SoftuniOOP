using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
[assembly: AssemblyVersion("0.1")]
namespace SoftUNIHW_OOP_4
{
    class GenericList<T>
    {
        private T[] genArray = new T[16];
        private int lastElement = 0;

        public T[] GenArray
        {
            get { return genArray; }
            set { genArray = value; }
        }

        public void Add(T element)
        {
            if (lastElement >= genArray.Length-1)
            {
                T[] newArray = new T[genArray.Length*2];
                for (int i = 0; i < genArray.Length; i++)
                {
                    newArray[i] = genArray[i];
                }
                genArray = newArray;
            }
            genArray[lastElement] = element;
            lastElement++;
        }

        public void Remove(int position)
        {
            if (position > 0 && position < genArray.Length)
            {
                genArray[position] = default(T);
            }
            else
            {
                throw new IndexOutOfRangeException("Given Index is out of range!");
            }
        }

        public T Get(int position)
        {
            if (position > 0 && position < genArray.Length)
            {
                return genArray[position];
            }
            else
            {
                throw new IndexOutOfRangeException("Given Index is out of range!");
            }
        }

        public void Clear()
        {
            genArray = new T[0];
        }

        public int[] Find(T value)
        {
            List<int> idxArray = new List<int>();
            for (int i = 0; i < genArray.Length; i++)
            {
                if (Equals(genArray[i], value))
                {
                    idxArray.Add(i);
                }
            }
            return idxArray.ToArray();
        }

        public void Insert(T value, int position)
        {
            if (position > 0 && position < lastElement)
            {
                T[] newArray = new T[genArray.Length + 1];
                for (int i = 0; i < position; i++)
                {
                    newArray[i] = genArray[i];
                }
                newArray[position] = value;
                for (int i = position + 1; i < genArray.Length; i++)
                {
                    newArray[i + 1] = genArray[i];
                }
                this.genArray = newArray;
            }
            else
            {
                throw new IndexOutOfRangeException("Given Index out of range!");
            }
        }
        public bool Contains(T value)
        {
            bool result = false;
            for (int i = 0; i < genArray.Length; i++)
            {
                if (Equals(genArray[i], value))
                {
                    result = true;
                }
            }
            return result;
        }

        public override string ToString()
        {
            string str = default(string);
            int counter = 0;
            foreach (T item in genArray)
            {
                if ( item != null && !item.Equals(default(T)) )
                {
                    str = String.Format("{0}{2}.{1}\n",str, item,counter);
                    counter++;
                }
            }
            return str;
        }

        public GenericList(T[] array)
        {
            this.genArray = array;
            this.lastElement = array.Length - 1;
        }
        public GenericList()
        {
            this.genArray = new T[16];
        }

        public T Max()
        {
            T[] Sorted = genArray;
            Array.Sort(Sorted);
            return (Sorted[Sorted.Length - 1]);
        }

        public T Min()
        {
            T[] Sorted = genArray;
            Array.Sort(Sorted);
            return (Sorted[0]);
        }
        public T Max(IComparer comp)
        {
            T[] Sorted = genArray;
            Array.Sort(Sorted, comp);
            return (Sorted[Sorted.Length - 1]);
        }

        public T Min(IComparer comp)
        {
            T[] Sorted = genArray;
            Array.Sort(Sorted, comp);
            return (Sorted[0]);
        }
    }

    class ListTester
    {
        public static void Tester()
        {
            Console.WriteLine("This is the Generic List Version {0}.", typeof(GenericList<>).Assembly.GetName().Version);
            Console.WriteLine("This is going to Generate 10 random strings, doubles and ints.\n Press the Any key to continue.");
            Console.ReadKey();
            Console.WriteLine("\n\n\nstrings\n\n\n");
            GenerateThings<string>();
            Console.WriteLine("\n\n\ndoubles\n\n\n");
            GenerateThings<double>();
            Console.WriteLine("\n\n\nints\n\n\n");
            GenerateThings<int>();
        }

        private static void GenerateThings<T>()
        {
            GenericList<T> list= new GenericList<T>();
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                T thing = default(T);
                if (typeof(T) == typeof(string))
                {
                    char[] charArray = new char[30];
                    for (int j = 0; j < 30; j++)
                    {
                        int value = r.Next(1, 200);
                        charArray[j] = Convert.ToChar(value);
                    }
                    string rndstr = new string(charArray);
                    thing = (T) Convert.ChangeType(rndstr, typeof(T));
                }
                if (typeof(T) == typeof(int))
                {
                    int rndval = r.Next(1, int.MaxValue);
                    thing = (T)Convert.ChangeType(rndval, typeof(T));
                }
                if (typeof(T) == typeof(double))
                {
                    double rnddub = r.NextDouble()*r.Next(1, 100000);
                    thing = (T)Convert.ChangeType(rnddub, typeof(T));
                }
                list.Add(thing);
            }
            Console.WriteLine(list.ToString());
        }

    }
}
