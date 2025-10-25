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
        List<User> users;
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
            users = new List<User>();
            users.Add(new User()
            {
                Id = 1,
                FirstName = "Can",
                LastName = "Perk",
                BirthDate = new DateOnly(1990, 2, 7),
                City = cities[0]
            });
            users.Add(new User()
            {
                Id = 2,
                FirstName = "Onur",
                LastName = "Özsoy",
                BirthDate = new DateOnly(1993, 10, 20),
                City = cities[4]
            });
            users.Add(new User()
            {
                Id = 3,
                FirstName = "Taha Can",
                LastName = "Aşkar",
                BirthDate = new DateOnly(1993, 10, 20),
                City = cities[4]
            });
        }

        // List ile ReadOnlyCollection farkını hatırla
        public ReadOnlyCollection<City> GetCities()
        {
            return cities.AsReadOnly();
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }
}
