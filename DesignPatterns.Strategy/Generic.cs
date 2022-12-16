namespace DesignPatterns.Strategy
{
    public class Work<T> where T : class, IStrategy, new()
    {
        public void Do() => 
            new T().Do();
    }

    public interface IStrategy
    {
        void Do();
    }

    public class StrategyA : IStrategy
    {
        public void Do() => 
            Console.WriteLine($"Doing {nameof(StrategyA)}");
    }

    public class StrategyB : IStrategy
    {
        public void Do() =>
            Console.WriteLine($"Doing {nameof(StrategyB)}");
    }
}