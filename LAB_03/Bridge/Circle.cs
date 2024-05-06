namespace Bridge
{
    public class Circle : Shape
    {
        public Circle(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            shape.Render("Circle");
        }
    }
}
