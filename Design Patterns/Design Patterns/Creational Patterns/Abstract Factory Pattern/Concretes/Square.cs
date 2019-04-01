using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Triangule::draw() method.");
        }
    }
}
