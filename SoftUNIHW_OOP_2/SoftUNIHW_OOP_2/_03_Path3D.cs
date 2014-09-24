using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_2
{
    class Path3D
    {
        public List<Point3D> points = new List<Point3D>();
        public void AddPoint(Point3D point3D)
        {
            points.Add(point3D);
        }

        public Path3D(Point3D[] points)
        {
            foreach (Point3D point in points)
            {
                AddPoint(point);
            }
        }
        
        public Path3D(){}
    }

}
