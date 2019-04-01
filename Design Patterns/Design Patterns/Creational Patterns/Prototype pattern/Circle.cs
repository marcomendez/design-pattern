using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Prototype_pattern
{
    public class Circle:Shape
    {

        public Circle()
        {
            type = "Circle";
        }
        public override void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
