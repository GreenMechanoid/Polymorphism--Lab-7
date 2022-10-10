//Daniel Svensson .Net22
namespace Polymorphism__Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sketch sketch = new Circle(5);
            Console.WriteLine($"Area of Circle: {sketch.Area()}");
            sketch = new Rectangle(5, 5);
            Console.WriteLine($"Area of Rectangle: {sketch.Area()}");
            sketch = new Triangle(3, 5, 5);
            Console.WriteLine($"Area of Triangle: {sketch.Area()}");
        }
    }
}