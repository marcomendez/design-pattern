using System;
using System.Threading;

namespace Design_Patterns.Structural_Patterns.Fyweight_Pattern
{
    public class FlyweightRun
    {
        public void run()
        {
            Console.WriteLine("************************** FlyweightRun pattern **********************************");
            for (int i = 0; i < 20; ++i)
            {
                Thread.Sleep(500);
                Circle circle = (Circle)ShapeFactory.getCircle(colors[new Random().Next(0,4)]);
                circle.setX(getRandomX());
                circle.setY(getRandomY());
                circle.setRadius(100);
                circle.Draw();
            }
        }

        private static string[] colors = { "Red", "Green", "Blue", "White", "Black" };

        private static string getRandomColor()
        {
            int lenght = colors.Length;

            return colors[(int)(new Random().Next(0,5) * lenght-1)];
        }
        private static int getRandomX()
        {
            return (int)(new Random().Next(1,3) * 100);
        }
        private static int getRandomY()
        {
            return (int)(new Random().Next(1,3) * 100);
        }
    }
}
