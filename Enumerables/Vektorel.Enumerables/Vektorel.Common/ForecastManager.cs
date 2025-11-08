using Vektorel.Common.Models;

namespace Vektorel.Common
{
    public delegate void CityAdded(string city);

    public class ForecastManager
    {
        private readonly Dictionary<string, List<Forecast>> cityForecast;

        public ForecastManager()
        {
            cityForecast = new Dictionary<string, List<Forecast>>();
        }

        public event CityAdded OnCityAdded;

        public void AddCity(string name)
        {
            if (cityForecast.ContainsKey(name))
            {
                return;
            }
            cityForecast.Add(name, new List<Forecast>());
            if (OnCityAdded != null)
            {
                OnCityAdded.Invoke(name);
            }
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
    }
}
