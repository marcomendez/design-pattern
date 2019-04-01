using System;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public abstract class AbstractFactory
    {
       public abstract IShape GetShape(string shapeType);
    }
}
