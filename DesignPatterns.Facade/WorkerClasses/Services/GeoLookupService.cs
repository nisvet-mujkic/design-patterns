using DesignPatterns.Facade.WorkerClasses.Entities;

namespace DesignPatterns.Facade.WorkerClasses.Services
{
    public class GeoLookupService
    {
        public City GetCityForZipCode(string zipCode) => new() { Name = "Sarajevo" };

        public State GetStateForZipCode(string zipCode) => new() { Name = "Kanton Sarajevo" };
    }
}