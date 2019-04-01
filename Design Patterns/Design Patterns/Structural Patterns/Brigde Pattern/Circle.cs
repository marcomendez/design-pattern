using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Brigde_Pattern
{
  public class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, DrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        public override void draw()
        {
            drawAPI.drawCircle(radius, x, y);
        }
    }
}
