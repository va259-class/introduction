using Vektorel.Inheritance.Base;

namespace Vektorel.Inheritance.Types.Coorporation
{
    internal abstract class Employee : Person
    {
        public DateOnly HireDate { get; set; }
        public decimal Salary { get; set; }
        public byte VacationDays { get; set; }
        public int SSN { get; set; }
    }
}
