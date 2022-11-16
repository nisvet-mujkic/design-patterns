using System.Runtime.Serialization;
using System.Xml.Linq;

namespace DesignPatterns.Flyweight
{
    // Flyweight blueprint
    public interface IDrinkFlyweight
    {
        // Intrinsic state - shared/readonly (private and shouldn't be modified from outside the concrete flyweight class)
        string Name { get; }

        // Extrinsic state
        void Serve(string size);
    }

    public class Espresso : IDrinkFlyweight
    {
        private string _name;

        private readonly IEnumerable<string> _ingredients = Enumerable.Empty<string>();

        public Espresso()
        {
            _name = "Espresso";
            _ingredients = new List<string>()
            {
                "Coffee Beans",
                "Hot Water"
            };
        }

        public string Name => _name;

        public void Serve(string size)
        {
            Console.WriteLine($"- {size} {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }

    public class BananaSmoothie : IDrinkFlyweight
    {
        private string _name;

        private readonly IEnumerable<string> _ingredients = Enumerable.Empty<string>();

        public BananaSmoothie()
        {
            _name = "Banana Smoothie";
            _ingredients = new List<string>()
            {
                "Banana",
                "Whole Milk",
                "Vanilla Extract"
            };
        }

        public string Name => _name;

        public void Serve(string size)
        {
            Console.WriteLine($"- {size} {_name} with {string.Join(", ", _ingredients)} coming up!");
        }
    }

    // Unshared concrete flyweight
    public class DrinkGiveaway : IDrinkFlyweight
    {
        // All state
        public string Name => _randomDrink.Name;

        private IDrinkFlyweight[] _eligibleDrinks = new IDrinkFlyweight[]
        {
            new Espresso(),
            new BananaSmoothie()
        };
        
        private IDrinkFlyweight _randomDrink;
        private string _size = string.Empty;

        public DrinkGiveaway()
        {
            var randomIndex = new Random().Next(0, 2);
            _randomDrink = _eligibleDrinks[randomIndex];
        }

        // Extrinsic state
        public void Serve(string size)
        {
            _size = size;

            Console.WriteLine("Free giveaway");
            Console.WriteLine($"- {size} {_randomDrink.Name} coming up!");
        }
    }
}
