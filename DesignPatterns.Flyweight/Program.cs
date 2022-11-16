namespace DesignPatterns.Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var drinkFactory = new DrinkFactory();

            var largeEspresso = drinkFactory.GetDrink("Espresso");
            largeEspresso.Serve("Large");

            var mediumSmoothie = drinkFactory.GetDrink("BananaSmoothie");
            mediumSmoothie.Serve("Medium");

            var smallEspresso = drinkFactory.GetDrink("Espresso");
            smallEspresso.Serve("Small");

            drinkFactory.ListDrinks();
        }
    }
}