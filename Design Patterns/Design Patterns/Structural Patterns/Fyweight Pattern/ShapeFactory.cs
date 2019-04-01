using System;
using System.Collections.Generic;

namespace Design_Patterns.Structural_Patterns.Fyweight_Pattern
{
    public class ShapeFactory
    {
        private static Dictionary<string, Shape> circleMap = new Dictionary<string, Shape>();

        public static Shape getCircle(string color)
        {

            Circle circle = !circleMap.ContainsKey(color) ? 
                            null:
                           (Circle)circleMap[color] ;
            if (circle == null)
            {
                circle = new Circle(color);
                circleMap.Add(color, circle);
                Console.WriteLine("Creating circle of color : " + color);
            }
            return circleMap[color];
        }
    }
}
