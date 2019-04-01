using System;

namespace Design_Patterns.Structural_Patterns.Facade_Pattern
{
    public class FacadeRun
    {
        public void run()
        {
            Console.WriteLine("************************** Facade pattern **********************************");
            ShapeMaker shapeMaker = new ShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}
