using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Decorator_Pattern
{
    public class DecoratorRun
    {

        public void run()
        {
            Console.WriteLine("************************** Decorator pattern **********************************");

            Console.WriteLine("\nCircle with normal border");
            Shape circle = new Circle();
            circle.Draw();


            Console.WriteLine("\nCircle of red border");
            Shape redCircle = new RedShapeDecorator(new Circle());
            redCircle.Draw();


            Console.WriteLine("\nRectangle of red border");
            Shape redRectangle = new RedShapeDecorator(new Rectangle());
            redRectangle.Draw();


            Console.WriteLine("\nRectangle of red and Blue border");
            new BlueShapeDecorator(redRectangle).Draw();

        }
    }
}
