using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Factory_Method
{
   public class RunFactory
    {
        public void run()
        {
            Console.WriteLine("************************** Factory pattern **********************************");
            IVehicule car = FactoryVehicule.Build("car");
            IVehicule moto = FactoryVehicule.Build("moto");
            IVehicule truck = FactoryVehicule.Build("trunk");

            Console.WriteLine("****************************************************************************");
        }
    }
}
