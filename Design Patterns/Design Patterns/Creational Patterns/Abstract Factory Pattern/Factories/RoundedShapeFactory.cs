﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class RoundedShapeFactory : AbstractFactory
    {
        public override IShape GetShape(string shapeType)
        {
            if (shapeType.Equals("RECTANGLE"))
            {
                return new RoundedRectangle();
            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new RounderSquare();
            }
            return null;
        }
    }
}
