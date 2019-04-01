using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Pattern
{

    public class Rectangle : IShape
    {

        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }

    }
}
