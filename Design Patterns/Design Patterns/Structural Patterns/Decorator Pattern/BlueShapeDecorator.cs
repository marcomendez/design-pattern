using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Patterns.Decorator_Pattern
{
   public class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator(Shape decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            decoratedShape.Draw();
            SetRedBorder(decoratedShape);
        }

        private void SetRedBorder(Shape decoratedShape)
        {
            Console.WriteLine("Border color: Blue");
        }
    }
}
