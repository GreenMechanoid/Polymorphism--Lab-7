//Daniel Svensson .Net22
namespace Polymorphism__Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
            //i'm including inline method calls simply to shave code.
        {
            Sketch sketch; // making the baseclass as starter point
            sketch = new Circle(5);// polymorphed to a circle
            Console.WriteLine($"Area of Circle: {sketch.Area()}");
            sketch = new Rectangle(5, 5);// polymorphed to a rectangle
            Console.WriteLine($"Area of Rectangle: {sketch.Area()}");
            sketch = new Triangle(3, 5, 5); // polymorphed to a triangle
            Console.WriteLine($"Area of Triangle: {sketch.Area()}");
        }

        /*
        could have put in Userinputs for the values during running, 
        but as it's not called for in the assignment of this lab then im skipping it
         */
    }
}