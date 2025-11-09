using Vektorel.Common.Models;

namespace Vektorel.Common
{
    public delegate void CityAdded(string city);
    public delegate void ForecastPublished(string city);

    public class ForecastManager
    {
        private readonly Dictionary<string, List<Forecast>> cityForecast;

        public ForecastManager()
        {
            cityForecast = new Dictionary<string, List<Forecast>>();
        }

        public event CityAdded OnCityAdded;
        public event ForecastPublished OnForecastPublished;

        public void AddCity(string city)
        {
            if (cityForecast.ContainsKey(city))
            {
                return;
            }
            cityForecast.Add(city, new List<Forecast>());
            if (OnCityAdded != null)//bu instance'ta event'e bağlanıldı ise
            {
                OnCityAdded.Invoke(city);
            }

            //Kısa yazım
            //OnCityAdded?.Invoke(city);
        }

        public int CityCount { get { return cityForecast.Count; } }

        public List<Forecast> GetCityForecasts(string name)
        {
            if (cityForecast.ContainsKey(name))
            {
                return cityForecast[name];
            }
            return null;
        }

        public void AddForecast(string city, Forecast forecast)
        {
            if (!cityForecast.ContainsKey(city)) // ekleme yapılacak şehir yoksa çık
            {
                return;
            }

            var forecasts = cityForecast[city];
            forecasts.Add(forecast);
            OnForecastPublished?.Invoke(city);
        }
    }
}
