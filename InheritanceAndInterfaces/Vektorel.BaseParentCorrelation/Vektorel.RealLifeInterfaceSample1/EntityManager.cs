using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vektorel.RealLifeInterfaceSample1.Entities;
using Vektorel.RealLifeInterfaceSample1.Interfaces;

namespace Vektorel.RealLifeInterfaceSample1
{
    internal class EntityManager
    {
        public void Manage()
        {
            var u1 = new User
            {
                UserName = "can",
                Password = "123"
            };

            var u2 = new User
            {
                UserName = "omerfaruk",
                Password = "123"
            };

            var m1 = new Message(u1.UserName)
            {
                Title = "Bayram Mesajı",
                Content = "Bayramınızı en içten dileklerimle kutlarım"
            };

            var l1 = new Location 
            { 
                Name = "Kızılay",
                Latitude = 39.045M,
                Longitude = 40.673M,
                CreatedBy = u2.UserName
            };

            l1.Name = "Kızılay Meydanı";
            // is ifadesi bir tipi diğer tiple ilişkisi olup olmadığını döner
            if (l1 is IModifiedAt) 
            {
                Console.WriteLine($"{l1.Name} güncellendi ve değiştirme tarihi değiştirildi");
            }

            u1.Password = "124";
            // is ifadesi true ise u1 değişkenini sadece IMofiedAt yap
            if (u1 is IModifiedAt modifiedUser) 
            {
                //u1.ModifiedAt = DateTime.Now;
                modifiedUser.ModifiedAt = DateTime.Now;
            }
        }
    }
}
