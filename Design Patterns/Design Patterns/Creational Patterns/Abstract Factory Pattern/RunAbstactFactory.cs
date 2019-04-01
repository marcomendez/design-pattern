using System;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class RunAbstactFactory
    {
        public void Run()
        {
            Console.WriteLine("************************** Abstract factory Pattern **************************");

            //get rounded shape factory
            // AbstractFactory roundedShapeFactory = FactoryProducer.getFactory("rounderShape");
            AbstractFactory ShapeFactory = FactoryProducer.getFactory("Normal");

            //get an object of Shape Rounded Rectangle
            IShape rectangule = ShapeFactory.GetShape("RECTANGLE");
            //call draw method of Shape Rectangle
            rectangule.Draw();

            //get an object of Shape Rounded Square 
            IShape square = ShapeFactory.GetShape("SQUARE");
            //call draw method of Shape Square
            square.Draw();

            Console.WriteLine("*****************************************************************************");

        }
    }
}
