using DesignPatterns.Facade.WorkerClasses.Contracts;
using DesignPatterns.Facade.WorkerClasses.Services;

namespace DesignPatterns.Facade.WorkerClasses.Facades
{
    public class WeatherFacade : IWeatherFacade
    {
        private readonly GeoLookupService _geoLookupService;
        private readonly WeatherService _weatherService;
        private readonly ConverterService _converterService;

        public WeatherFacade() :
            this(new GeoLookupService(), new WeatherService(), new ConverterService())
        {
        }

        public WeatherFacade(GeoLookupService geoLookupService, WeatherService weatherService, ConverterService converterService)
        {
            _geoLookupService = geoLookupService;
            _weatherService = weatherService;
            _converterService = converterService;
        }

        public int GetTempInCity(string zipCode)
        {
            var city = _geoLookupService.GetCityForZipCode(zipCode);
            var state = _geoLookupService.GetStateForZipCode(zipCode);

            var fahrenheit = _weatherService.GetTempFahrenheit(city, state);
            var celsius = _converterService.ConvertFahrenheitToCelsius(fahrenheit);

            return celsius;
        }
    }
}