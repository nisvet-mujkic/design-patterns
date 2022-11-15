namespace DesignPatterns.Facade.WorkerClasses.Contracts
{
    public interface IWeatherFacade
    {
        public int GetTempInCity(string zipCode);
    }
}