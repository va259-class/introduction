using Vektorel.StaticNonStatic.Sample.Managers;
using Vektorel.StaticNonStatic.Sample.Models;

namespace Vektorel.StaticNonStatic.Sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mevcut dışarıdan atanmamalı!!!
            //SchoolManager.StudentCount = 20;
            var st1 = new Student(614)
            {
                FirstName = "Can",
                LastName = "Perk",
                Grade = 4.4
            };
            var st2 = new Student(605)
            {
                FirstName = "Samed",
                LastName = "Parıltı",
                Grade = 4.8
            };

            SchoolManager.Add(st1);
            SchoolManager.Add(st2);

            Console.WriteLine("Okul Ortalaması:     {0}", SchoolManager.GetAverageGrade());
            Console.WriteLine("Okul Başarı Durumu:  {0}", SchoolManager.GetSchoolRate());
        }
    }
}
