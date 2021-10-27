using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1
{
    class Triangle // Klass triangel
    {
        public double katet1;  // Egenskaper
        public double katet2;
        public double hypotenusa;
        public double depth;

        public Triangle(double inputKatet1, double inputKatet2, double inputDepth) // Konstruktor
        {
            katet1 = inputKatet1;
            katet2 = inputKatet2;
            depth = inputDepth;
            hypotenusa = System.Math.Sqrt(katet1 * katet1 + katet2 * katet2);
        }
        public double getArea() // Ränkar ut arean på en triangel
        {
            return (katet1 * katet2 / 2);
        }

        public double getCircumference() // Räknar ut omkretsen på en triangel
        {
            return (hypotenusa + katet1 + katet2);

        }
        public double getVolume() // Räknar ut volymen på en triangel
        {
            return ((katet1+katet1) * katet2 /2 * depth);
        }
    }
}
