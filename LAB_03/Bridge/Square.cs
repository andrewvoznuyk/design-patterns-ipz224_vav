using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Square : Shape
    {
        public Square(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            shape.Render("Square");
        }
    }
}
