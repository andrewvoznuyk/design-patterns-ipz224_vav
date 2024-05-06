namespace Bridge
{
    public abstract class Shape
    {
        protected IShape shape;

        public Shape(IShape shape)
        {
            this.shape = shape;
        }

        public abstract void Draw();
    }
}
