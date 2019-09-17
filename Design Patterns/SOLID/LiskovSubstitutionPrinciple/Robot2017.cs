using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitutionPrinciple
{
    public class Robot2017 : Robot
    {
        public override int Attack()
        {
            return 150;
        }
    }
}
