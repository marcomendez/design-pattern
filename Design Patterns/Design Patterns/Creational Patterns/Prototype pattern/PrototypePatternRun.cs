using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Prototype_pattern
{
  public  class PrototypePatternRun
    {
        public void run()
        {

            Console.WriteLine("************************** Prototyte pattern **********************************");
            ShapeCache.loadCache();
            Shape clonedShape = ShapeCache.GetShape("1");
            Console.WriteLine( "Shape : " + clonedShape.getType());

            Shape clonedShape2 = ShapeCache.GetShape("2");
            Console.WriteLine("Shape : " + clonedShape2.getType());

            Shape clonedShape3 = ShapeCache.GetShape("3");
            Console.WriteLine("Shape : " + clonedShape3.getType());

            Console.WriteLine("******************************************************************************");
        }
    }
}
