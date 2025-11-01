using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Types.Coorporation
{
    internal class Intern : Employee
    {
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }

    internal class PermanentEmployee : Employee
    {

    }

    internal class Consultant : Employee
    {
        public Project Project { get; set; }
        public short TotalDays { get; set; }
        public short UsedDays { get; set; }
        public short LeftDays 
        { 
            get 
            { 
                return (short)(TotalDays - UsedDays); 
            }
        }
    }

    internal class ContractedEmployee : Employee
    {
        public DateOnly EndDate { get; set; }
    }
}
