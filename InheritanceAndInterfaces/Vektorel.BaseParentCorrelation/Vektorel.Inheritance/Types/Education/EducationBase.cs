using Vektorel.Inheritance.Base;
using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Types.Education
{
    internal abstract class EducationBase : Person
    {
        public string SchoolName { get; set; }
        public SchoolLevel Level { get; set; }
    }
}
