using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Creational_Patterns.Factory_Method
{
  public static class FactoryVehicule
    {
        public static IVehicule Build(string type)
        {
            switch (type)
            {
                case "car":
                    return new Car();
                case "trunk":
                    return new Truck();
                case "moto":
                    return new MotoCiclete();
                default:
                    return null;
            }
        }
    }
}
