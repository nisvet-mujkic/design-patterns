namespace DesignPatterns.Flyweight
{
    public class DrinkFactory
    {
        private Dictionary<string, IDrinkFlyweight> _drinkCache = new();

        public int ObjectsCreated = 0;

        public IDrinkFlyweight GetDrink(string drinkKey)
        {
            IDrinkFlyweight drink = null;

            if (_drinkCache.TryGetValue(drinkKey, out IDrinkFlyweight cachedDrink))
            {
                Console.WriteLine("Reusing existing flyweight object.");

                return cachedDrink;
            }

            Console.WriteLine("Creating new flyweight object");

            drink = drinkKey switch
            {
                "Espresso" => new Espresso(),
                "BananaSmoothie" => new BananaSmoothie(),
                _ => throw new InvalidOperationException(),
            };
            _drinkCache.Add(drinkKey, drink);

            ObjectsCreated++;

            return drink;
        }

        public IDrinkFlyweight CreateGiveaway() => new DrinkGiveaway();

        public void ListDrinks()
        {
            Console.WriteLine($"Factory has {_drinkCache.Count} drinks.");
            Console.WriteLine($"Number of objects created so far {ObjectsCreated}.");

            foreach (var drink in _drinkCache.Values)
            {
                Console.WriteLine(drink.Name);
            }
        }
    }
}
