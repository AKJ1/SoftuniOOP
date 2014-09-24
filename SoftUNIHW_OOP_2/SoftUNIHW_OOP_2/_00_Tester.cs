using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_2
{
    static class Test
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are now going to be Testing Point3D and Distance, Press the any key to continue . . .");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            TestDistance();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test Sucessful! You are now going to be testing Path3D with randomly generated points. Press the any key to continue. . .");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            TestPath();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Great Job! Next You test the HTML Dispatcher.");
        }
        public static void TestPath()
        {
            Path3D path = new Path3D(generateRandomPoints(50));
            Console.WriteLine();
            Storage.Save("C:\\Temp\\output.txt", path);
            Path3D secondPath = Storage.Load("C:\\Temp\\output.txt");
            Storage.Save("C:\\Temp\\Output2.txt", secondPath);
            Console.WriteLine("Great Sucess! Check C:/Temp/!");
            Console.ReadKey();
        }

        public static void TestDistance()
        {
            float x, y, z;
            Console.WriteLine("You're about to enter the XYZ coordinates of two points:");
            Console.WriteLine("Point One");
            Console.WriteLine("Enter X:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Z:");
            z = float.Parse(Console.ReadLine());
            Point3D firstPoint3D = new Point3D(x, y, z);
            Console.WriteLine("Point Two");
            Console.WriteLine("Enter X:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Z:");
            z = float.Parse(Console.ReadLine());
            Point3D secondPoint3D = new Point3D(x, y, z);
            float result = DistanceCalculator.CalculateDistance(firstPoint3D, secondPoint3D);
            Console.WriteLine("Calculated Distance is {0}", result);
        }
        private static Point3D[] generateRandomPoints(int count)
        {
            Random R = new Random();
            Point3D[] pointArray = new Point3D[count];
            for (int i = 0; i < count; i++)
            {
                pointArray[i] = new Point3D((float)R.Next(1, 100), (float)R.Next(1, 100), (float)R.Next(1, 100));
            }
            return pointArray;
        }
    }
}
