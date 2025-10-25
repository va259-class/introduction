using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.UserManagement.Models;

namespace Vektorel.UserManagement.Helpers
{
    internal class FakeDataProvider
    {
        List<City> cities;
        //Constructor nedir hatırla
        public FakeDataProvider()
        {
            cities = new List<City>
            {
                new City() { Id = 1, Name = "Ankara" },
                new City() { Id = 2, Name = "İstanbul" },
                new City() { Id = 3, Name = "İzmir" },
                new City() { Id = 4, Name = "Adana" },
                new City() { Id = 5, Name = "Bursa" },
                new City() { Id = 6, Name = "Trabzon" },
                new City() { Id = 7, Name = "Gaziantep" }
            };
        }

        // List ile ReadOnlyCollection farkını hatırla
        public ReadOnlyCollection<City> GetCities()
        {
            return cities.AsReadOnly();
        }
    }
}
