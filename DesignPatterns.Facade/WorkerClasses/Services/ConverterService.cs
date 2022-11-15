namespace DesignPatterns.Facade.WorkerClasses.Services
{
    public class ConverterService
    {
        public int ConvertFahrenheitToCelsius(int fahrenheit) => (fahrenheit - 32) * 5 / 9;
    }
}