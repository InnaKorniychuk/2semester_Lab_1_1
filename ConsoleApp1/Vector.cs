using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vector
    {
        private double x;
        private double y;
        public Vector(double x, double y)
        {
            X= x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
            set
            {
                x = value;
            }
        }
        public double GetY() { return y; }
        public void SetY(double Y)
        {
            y = Y + 10;
            
        }

    }
}
