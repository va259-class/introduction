using System.Xml.Linq;

namespace Vektorel.ConditionsSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m1 = new Membership();
            m1.PrintStatus();

            var m2 = new Membership();
            m2.Register("Can Perk");
            m2.PrintStatus();
            m2.Accept();
            m2.PrintStatus();

            Thread.Sleep(11000);// uygulamayı 11 saniye dondur

            var m3 = new Membership();
            m3.Register("Furkan Kaymak");
            m3.PrintStatus();
            m3.Accept();
            m3.PrintStatus();

            m2.UseCampaign();
            m3.UseCampaign();
        }
    }
}

/*
KISS: Keep It Simple and Stupid
YAGNI: You Aren't Gonna Need It
DRY: Don't Repeat Yourself
SOLID: 
 - Single Responsibility
 - Open Close
 - Liskov's Substitution
 - Interface Segregation
 - Dependency Inversion
 */