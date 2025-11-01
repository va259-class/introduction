using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Types.Education
{
    internal class Teacher : EducationBase
    {
        public Department Department { get; set; }
        public ClassRoom ResponsibleFor { get; set; }

    }
}
