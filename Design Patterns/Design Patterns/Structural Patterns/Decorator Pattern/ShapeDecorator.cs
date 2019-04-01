namespace Design_Patterns.Structural_Patterns.Decorator_Pattern
{
    public abstract class ShapeDecorator : Shape
    {
        protected Shape decoratedShape;

        public ShapeDecorator(Shape decoratorShape)
        {
            this.decoratedShape = decoratorShape;
        }

        public virtual void Draw()
        {
            decoratedShape.Draw();
        }
    }
}
