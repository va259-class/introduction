using Vektorel.Inheritance.Base;
using Vektorel.Inheritance.Enums;
using Vektorel.Inheritance.Types.Coorporation;
using Vektorel.Inheritance.Types.Education;

namespace Vektorel.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = new Intern();
            i.FullName = "Gökçe Yıldız";
            i.BirthDate = new DateOnly(2004, 5, 6);
            i.Gender = Gender.Female;
            i.SSN = 34532323;
            i.HireDate = new DateOnly(2025, 10, 28);
            i.StartDate = i.HireDate.AddDays(3);
            i.EndDate = i.StartDate.AddDays(20);

            var c = new Consultant();
            c.FullName = "Taner Akdağ";
            c.BirthDate = new DateOnly(1986, 4, 18);
            c.Gender = Gender.Female;
            c.HireDate = new DateOnly(2023, 6, 17);
            c.Project = Project.Law;
            c.TotalDays = 100;
            c.UsedDays = 60;

            var s1 = new Student();
            s1.FullName = "Caner Kaya";
            s1.BirthDate = new DateOnly(2010, 4, 5);
            s1.Number = 11;
            s1.Level = SchoolLevel.High;

            var s2 = new Student("Pelin Şahin", new DateOnly(2011, 4, 16), SchoolLevel.High, 139);

            var s3 = new Student
            {
                FullName = "Yıldıray Bakır",
                BirthDate = new DateOnly(2015, 8, 22),
                Gender = Gender.Male,
                Grade = 4.76,
                Level = SchoolLevel.Secondary,
                Number = 339,
                SchoolName = "Gazi Ortaokulu"
            };

            var cl1 = new ClassRoom
            {
                Label = "10A"
            };
            cl1.Students.Add(s1);

            var cl2 = new ClassRoom
            {
                Label = "11A"
            };

            var cl3 = new ClassRoom
            {
                Label = "12A"
            };

            var t1 = new Teacher();
            t1.FullName = "Çağlar Timur";
            t1.Department = Department.History;
            t1.ResponsibleFor = cl1;
            t1.BirthDate = new DateOnly(1991, 5, 30);

            var o1 = new School
            {
                Name = "Alparslan Lisesi"
            };

            var sp = new ServicePerson { FullName = "Rüstem Koçer" };
            o1.Register(s2);
            o1.Register(s2);
            o1.Register(t1);
            o1.Register(sp);
        }
    }
}

/*
class
struct
enum
interface
event
delegate
 */