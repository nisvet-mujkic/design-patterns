namespace DesignPatterns.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var root = Category.CreateRoot();

            var categoryA = root.CreateSubcategory("CATEGORY A");
            var subCategoryA = categoryA.CreateSubcategory("SUBCATEGORY A");

            var categoryB = root.CreateSubcategory("CATEGORY B");

            var book = new Product("Book", root);
            var pencil = new Product("Pencil", subCategoryA);

            Console.WriteLine(pencil);
        }
    }
}