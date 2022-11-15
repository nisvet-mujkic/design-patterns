using DesignPatterns.Facade.BallOfMud;
using DesignPatterns.Facade.WorkerClasses.Facades;

namespace DesignPatterns.Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bigClassFacade = new BigClassFacade();

            bigClassFacade.IncrementBy(50);
            bigClassFacade.DecrementBy(20);

            Console.WriteLine(bigClassFacade.GetCurrentValue());

            var weatherFacade = new WeatherFacade();

            var temp = weatherFacade.GetTempInCity("9803");

            Console.WriteLine(temp);
        }
    }
}