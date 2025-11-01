using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Types.Coorporation
{
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
}
