using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_2
{
    static class Storage
    {
        public static void Save(string file, Path3D path)
        {
            FileStream fs = File.Create(file);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Point3D point in path.points)
            {
                sw.WriteLine(point.ToString());
            }
            sw.Close();
            fs.Close();
        }

        public static Path3D Load(string file)
        {
            string[] readContents = File.ReadAllLines(file);
            Path3D path = new Path3D();
            foreach (string line in readContents)
            {
                string[] numbers = line.Split(',');
                path.AddPoint(new Point3D(float.Parse(numbers[0]), float.Parse(numbers[1]), float.Parse(numbers[2])));
            }
            return path;
        }
    }

}
