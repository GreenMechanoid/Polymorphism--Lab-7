//Daniel Svensson .Net22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism__Lab_7
{
    internal abstract class Sketch
        //abstract Base class
    {
        protected double FullArea = 0; // used in all the others so it's here

        public virtual double Area()
        {

            Console.WriteLine("This is the Abstract method, Wrong call of the method! Result = 0");
            return this.FullArea;
        }

    }

    internal class Circle : Sketch
    {
        protected float Pi = 3.14159265359f; // just grabbed pi from a calculator..
        protected double Radius { get; set; } 
        // dont really need the get/set here as i'm not trying to protect the variables from outside influence

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double Area()
        //Overridden for area of a circle
        {
            this.FullArea = this.Radius * this.Radius * this.Pi;
            return this.FullArea;
        }
    }
    internal class Rectangle : Sketch
    {
        protected double Height { get; set; } // need 2 numbers to calculate the area of a rectangle, 
        protected double Width { get; set; }

        public Rectangle(double height,double width)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double Area()
        //Overridden for area of a rectangle
        {

            this.FullArea = Height * Width;
            return this.FullArea;
        }
    }
    internal class Triangle : Sketch
    {
        protected double TriBase { get; set; } // need 3 numbers to calculate area of a triangle
        protected double TriHeight { get; set; }
        protected double TriHypo { get; set; }
        
        public Triangle(double triBase, double triHeight, double triHypo)
        {
            this.TriBase = triBase;
            this.TriHeight = triHeight;
            this.TriHypo = triHypo;
        }
        public override double Area()
            //Overridden for area of a triangle
        {
            //nabbed this from old lab with small adjustment, reused code from lab3 
            double SemiAreaOfTriangle = (this.TriBase + this.TriHeight + this.TriHypo) / 2; // calculate the Semi-perimeter
            double AreaOfTriangle = SemiAreaOfTriangle * (SemiAreaOfTriangle - this.TriBase)
                * (SemiAreaOfTriangle - this.TriHeight) * (SemiAreaOfTriangle - this.TriHypo); // calculate the full area
            return Math.Sqrt(AreaOfTriangle);
        }
    }
}
