using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Brigde_Pattern
{
    public class BridgeRun
    {
        public void run()
        {
            Console.WriteLine("************************** Bridge pattern **********************************");
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.draw();
            greenCircle.draw();

            Console.WriteLine("******************************************************************************");
        }
    }
}
