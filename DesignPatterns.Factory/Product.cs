namespace DesignPatterns.Factory
{
    public class Product
    {
        public Product(string name, Category category)
        {
            Name = name;
            Category = category;
        }

        public string Name { get; }

        public Category Category { get; }

        public override string ToString() => $"{Name} ({Category})";
    }
}