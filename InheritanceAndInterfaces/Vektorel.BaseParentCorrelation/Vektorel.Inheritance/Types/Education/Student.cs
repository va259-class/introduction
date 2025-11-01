using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Types.Education
{
    internal class Student : EducationBase
    {
        public Student()
        {
            
        }
        public Student(string fullName, DateOnly birthDate, SchoolLevel level, short number)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Level = level;
            Number = number;
        }
        public double Grade { get; set; }
        public short Number { get; set; }
    }
}
