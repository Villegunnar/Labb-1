using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1
{
    class Circle // Klass cirkel
    {

        public float pi = 3.14f; // Egenskaper
        public double radius;
        public Circle(double inputRadius) // Konstruktor
        {
            radius = inputRadius;
        }


        public double getArea() // Räknar ut arean på en cirkel
        {
            return (radius * radius * pi);
        }

        public double getCircumference() // Räknar ut omkretsen på en cirkel
        {
            return (radius * 2 * pi);
        }

        public double getVolume() // Räknar ut volymen på en cirkel
        {
            return (4 * pi * radius * radius * radius / 3);
        }

    }
}
