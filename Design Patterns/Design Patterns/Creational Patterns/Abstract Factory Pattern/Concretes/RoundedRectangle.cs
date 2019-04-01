using System;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    class RoundedRectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside RounderRectange::Draw() method.");
        }
    }
}
