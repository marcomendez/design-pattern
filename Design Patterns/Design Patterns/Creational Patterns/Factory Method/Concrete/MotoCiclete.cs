using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Factory_Method
{
    public class MotoCiclete : IVehicule
    {
        public MotoCiclete()
        {
            Console.WriteLine("Build Motociclete");
        }
    }
}
