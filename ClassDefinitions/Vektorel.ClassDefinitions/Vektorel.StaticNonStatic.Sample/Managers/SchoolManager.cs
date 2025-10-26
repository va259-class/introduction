using Vektorel.StaticNonStatic.Sample.Enums;
using Vektorel.StaticNonStatic.Sample.Models;

namespace Vektorel.StaticNonStatic.Sample.Managers
{
    internal static class SchoolManager
    {
        private static List<Student> students = new List<Student>();
       
        //property read only yapılmak istendi ancak her öğrenci eklendiğinde mevcut
        //artacağı için bu durum zor oluyor
        //o sebeple atama işlemi yalnızca bu class içinde kalmalı
        public static int StudentCount { get; private set; }

        public static void Add(Student student)
        {
            students.Add(student);
            //her öğrenci eklendiğinde mevcut 1 artsın
            StudentCount++;
        }

        public static double GetAverageGrade()
        {
            var sum = 0D;
            foreach (var student in students)
            {
                sum += student.Grade;
            }

            return sum / StudentCount;
        }

        public static SuccessRate GetSchoolRate()
        {
            var grade = GetAverageGrade();
            if (grade < 2D)
            {
                return SuccessRate.Bad;
            }
            else if (grade >= 2D && grade < 4.2)
            {
                return SuccessRate.Normal;
            }
            else 
            {
                return SuccessRate.Good;
            }
        }
    }
}
