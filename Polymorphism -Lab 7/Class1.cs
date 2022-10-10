//Daniel Svensson .Net22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism__Lab_7
{
    internal abstract class Sketch
    {
        private double ImNotAValue = 0;

        public virtual double Area(double inValue)
        {

            Console.WriteLine("This is the Abstract method, Wrong call of the method! Result = 0");
            return this.ImNotAValue;
        }
    }

    internal class Circle : Sketch
    {
        protected float Pi = 3.14159265359f; // just grabbed pi from a calculator..
        protected double Radius { get; set; }

        public override double Area(double radius)
        {
            Radius = radius * radius * Pi;
            return this.Radius;
        }
    }
    internal class Rectangle : Sketch
    {

    }
    internal class Triangle : Sketch
    {

    }
}
