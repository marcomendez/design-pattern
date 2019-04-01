using System;

namespace Design_Patterns.Abstract_Factory_Pattern
{
   public class RounderSquare : IShape
    {

        public void Draw()
        {
            Console.WriteLine("Inside RoundedSquare::draw() method.");
        }
    }
}
