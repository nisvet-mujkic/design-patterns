namespace DesignPatterns.Strategy
{
    public class Product
    {
        public Product(string title, Money price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; }

        public Money Price { get; }
    }

    public record Money(decimal Amount, Currency Currency)
    {
        public Money Substract(decimal amount)
        {
            if (amount > Amount)
                throw new InvalidOperationException();

            return new Money(Amount - amount, Currency);
        }
    }

    public record Currency(string Symbol);

    public class Offer
    {
        private readonly IModifier _modifier;
        private readonly Product _product;

        public Offer(IModifier modifier, Product product)
        {
            _modifier = modifier;
            _product = product;
        }

        public Product Apply()
        {
            return new Product(_product.Title, _modifier.ApplyTo(_product.Price));
        }
    }

    public interface IModifier
    {
        Money ApplyTo(Money price);
    }

    public class WeekendDiscount : IModifier
    {
        private readonly decimal _amount;
        private readonly DateTime _today;

        public WeekendDiscount(decimal amount, DateTime today)
        {
            _amount = amount;
            _today = today;
        }

        public Money ApplyTo(Money price) =>
            _today.IsWeekend() ? price.Substract(_amount) : price;
    }

    public static class DateTimeExtensions
    {
        public static bool IsWeekend(this DateTime date) =>
            date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
    }
}
