using System;

namespace Design_Patterns.Creational_Patterns.Prototype_pattern
{
    public class Rectangle : Shape
    {

        public Rectangle()
        {
            type = "Rectangle";
        }
        public override void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
