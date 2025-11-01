using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Base
{
    internal abstract class Person
    {
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        public int Age 
        { 
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
    }
}
