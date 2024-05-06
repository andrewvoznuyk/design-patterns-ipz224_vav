using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Triangle : Shape
    {
        public Triangle(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            shape.Render("Triangle");
        }
    }
}
