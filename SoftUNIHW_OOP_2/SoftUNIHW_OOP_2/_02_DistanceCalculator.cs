using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_2
{
    class DistanceCalculator
    {
        public static float CalculateDistance(Point3D a, Point3D b)
        {
            return (float) Math.Sqrt(Math.Pow(a.X - b.X, 2) + 
                            Math.Pow(a.Y - b.Y, 2) +
                            Math.Pow(a.Z + b.Z, 2));
        }
    }
}
