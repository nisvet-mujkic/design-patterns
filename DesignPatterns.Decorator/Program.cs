namespace DesignPatterns.Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var item = new Item("Item");

            Console.WriteLine(item.Title);

            var reversedItem = new ReversedItem(item);
            Console.WriteLine(reversedItem.Title);
        }
    }

    public abstract class ItemDecorator : IItem
    {
        private readonly IItem _target;

        protected ItemDecorator(IItem target)
        {
            _target = target;
        }

        public virtual string Title => _target.Title;
    }

    public interface IItem
    {
        string Title { get; }
    }

    public class Item : IItem
    {
        public string Title { get; }

        public Item(string title)
        {
            Title = title;
        }
    }

    public class ReversedItem : ItemDecorator
    {
        public ReversedItem(IItem target) : base(target)
        {
        }

        public override string Title => string.Join(string.Empty, base.Title.Reverse());
    }
}