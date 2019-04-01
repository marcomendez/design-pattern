using System;

namespace Design_Patterns.Structural_Patterns.Decorator_Pattern
{
    public class RedShapeDecorator: ShapeDecorator
    {
        public RedShapeDecorator(Shape decoratedShape): base(decoratedShape)
        {
        }

        public override void Draw()
        {
            decoratedShape.Draw();
            SetRedBorder(decoratedShape);
        }

        private void SetRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border color: Red");
        }

    }
}
