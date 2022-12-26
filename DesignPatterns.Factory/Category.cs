namespace DesignPatterns.Factory
{
    public abstract class Category
    {
        protected Category(string name)
        {
            Name = name;
        }

        public static Category CreateRoot() => 
            new RootCategory();

        public Category CreateSubcategory(string name) =>
            new InnerCategory(name, this);

        public string Name { get; }

        public override string ToString() =>
            string.Join(" > ", Path.Select(category => category.Name).ToArray());

        private IEnumerable<Category> Path =>
            NestingSequence().Reverse().DefaultIfEmpty(this);

        private IEnumerable<Category> NestingSequence()
        {
            var current = this;

            while(current is InnerCategory inner)
            {
                yield return current;
                current = inner.Parent;
            }
        }
    }

    public class RootCategory : Category
    {
        public RootCategory() : base("MAIN CATEGORY") { }

    }

    public class InnerCategory : Category
    {
        public InnerCategory(string name, Category parent) : base(name)
        {
            Parent = parent ?? throw new ArgumentNullException(nameof(parent));
        }

        public Category Parent { get; }
    }
}