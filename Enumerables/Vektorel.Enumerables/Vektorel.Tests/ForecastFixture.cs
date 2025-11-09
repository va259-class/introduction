using Vektorel.Common;
using Vektorel.Common.Models;

namespace Vektorel.Tests
{
    [TestFixture]
    public class ForecastFixture
    {
        public ForecastManager Sut {  get; set; }
        
        [SetUp]
        public void Refresh()
        {
            Sut = new ForecastManager();
        }

        [Test]
        public void CanAdd_NewCity()
        {
            Sut.OnCityAdded += Sut_OnCityAdded;
            Sut.AddCity("Ankara");
            Assert.That(Sut.CityCount, Is.EqualTo(1));

            var forecast = Sut.GetCityForecasts("Ankara");
            Assert.That(forecast.Count, Is.EqualTo(0));
        }

        private void Sut_OnCityAdded(string city)
        {
            Assert.That(city, Is.EqualTo("Ankara"));
        }

        [Test]
        public void CanAdd_NewCities()
        {
            Sut.AddCity("Ankara");
            Sut.AddCity("Edirne");
            Sut.AddCity("Kars");
            Sut.AddCity("Ankara");
            Assert.That(Sut.CityCount, Is.EqualTo(3));
        }

        [Test]
        public void CanAdd_NewCities_BulkData()
        {
            var cityNames = new string[]
            {
                "Ankara",
                "Ýstanbul",
                "Ýzmir",
                "Trabzon",
                "Adana",
                "Gaziantep"
            };
            for (int i = 0; i < 1000; i++)
            {
                var index = Random.Shared.Next(0, cityNames.Length);
                Sut.AddCity(cityNames[index]);
            }
            Assert.That(Sut.CityCount, Is.EqualTo(6));
        }

        [Test]
        public void CanAdd_Forecast()
        {
            Sut.AddCity("Kars");
            Sut.AddForecast("Kars", new Forecast(23, 500, 45, 23, "Güneþli"));

            Assert.That(Sut.GetCityForecasts("Kars").Count, Is.EqualTo(1));
        }

        [Test]
        public void CanAdd_Forecasts()
        {
            Sut.AddCity("Kars");
            Sut.AddForecast("Kars", new Forecast(23, 500, 45, 23, "Güneþli"));
            Sut.AddForecast("Kars", new Forecast(24, 400, 40, 20, "Parçalý Bulutlu"));
            Sut.AddForecast("Kars", new Forecast(26, 450, 38, 28, "Saðanak Yaðýþlý"));
            Sut.AddForecast("Kars", new Forecast(22, 600, 41, 11, "Güneþli"));
            Sut.AddForecast("Kars", new Forecast(24, 500, 46, 19, "Bulutlu"));

            Assert.That(Sut.GetCityForecasts("Kars").Count, Is.EqualTo(5));
        }

        [Test]
        public void CannotAdd_Forecast()
        {

        }
    }
}