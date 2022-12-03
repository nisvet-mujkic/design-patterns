namespace DesignPatterns.Bridge
{
    public abstract class Shape
    {
        protected readonly IColor _color;

        public Shape(IColor color)
        {
            _color = color;
        }

        public abstract void Draw();
    }

    public class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
        }

        public override void Draw()
        {
            
        }
    }

    public interface IColor
    {
        string GetColor();
    }

    public class Red : IColor
    {
        public string GetColor() => nameof(Red);
    }

    public class Blue : IColor
    {
        public string GetColor() => nameof(Blue);
    }
}
