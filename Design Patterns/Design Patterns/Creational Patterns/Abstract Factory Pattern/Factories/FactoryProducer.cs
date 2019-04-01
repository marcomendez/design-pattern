namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string abstractName)
        {
            if (abstractName.Equals("rounderShape"))
            {
                return new RoundedShapeFactory();
            }
            else if(abstractName.Equals("Normal"))
            {
                return new ShapeFactory();
            }
            return null;
        }
    }
}
