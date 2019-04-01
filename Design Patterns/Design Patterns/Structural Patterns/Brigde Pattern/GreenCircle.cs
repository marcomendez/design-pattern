using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Brigde_Pattern
{
    public class GreenCircle : DrawAPI
    {
        public void drawCircle(int radius, int x, int y)
        {
           Console.WriteLine("Drawing Circle[ color: green, radius: " + radius + ", x: " + x + ", " + y + "]");
        }
    }
}
