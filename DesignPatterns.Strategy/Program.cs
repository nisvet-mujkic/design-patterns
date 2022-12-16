namespace DesignPatterns.Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var storage = new S3();
            var fileController = new FileController(storage);

            var work = new Work<StrategyA>();
            work.Do();

            var product = new Product("Atomic Habits", new Money(16, new Currency("USD")));
            var offer = new Offer(new WeekendDiscount(10, DateTime.Now), product);

            var cart = offer.Apply();

            Console.WriteLine($"{cart.Title} - {cart.Price.Amount} {cart.Price.Currency.Symbol}");
        }
    }
}