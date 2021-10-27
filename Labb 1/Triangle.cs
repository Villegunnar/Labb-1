using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1
{
    class Triangle
    {
        public double katet1;
        public double katet2;
        public double hypotenusa;
        public double depth;

        public Triangle(double inputKatet1, double inputKatet2, double inputDepth)
        {
            katet1 = inputKatet1;
            katet2 = inputKatet2;
            depth = inputDepth;
            hypotenusa = System.Math.Sqrt(katet1 * katet1 + katet2 * katet2);
        }
        public double getArea()
        {
            return (katet1 * katet2 / 2);
        }

        public double getCircumference()
        {
            return (hypotenusa + katet1 + katet2);

        }
        public double getVolume()
        {
            return ((katet1+katet1) * katet2 /2 * depth);
        }
    }
}
