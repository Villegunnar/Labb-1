using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_1
{
    class Circle
    {

        public float pi = 3.14f;
        public double radius;
        public Circle(double inputRadius)
        {
            radius = inputRadius;
        }


        public double getArea()
        {
            return (radius * radius * pi);
        }

        public double getCircumference()
        {
            return (radius * 2 * pi);
        }

        public double getVolume()
        {
            return (4 * pi * radius * radius * radius / 3);
        }

    }
}
