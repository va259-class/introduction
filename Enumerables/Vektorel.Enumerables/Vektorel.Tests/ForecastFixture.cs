using Vektorel.Common;

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
    }
}