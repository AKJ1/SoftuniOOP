using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SoftUNIHW_OOP_2
{
    class Point3D
    {
        private float x;
        private float y;
        private float z;

        public float X
        {
            get { return x; }
            set { x = value; }
        }

        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public float Z
        {
            get { return z; }
            set { z = value; }
        }

        public Point3D(float X, float Y, float Z)
        {
            this.x = X;
            this.y = Y;
            this.z = Z;
        }

        public Point3D()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public override string ToString()
        {

            return String.Format("{0},{1},{2}", this.x, this.y, this.z);
        }
    }
}
