using Vektorel.Inheritance.Base;

namespace Vektorel.Inheritance.Types.Education
{
    internal class School
    {
        public string Name { get; set; }
        public void Register(EducationBase person)
        {
            person.SchoolName = Name;
        }
    }
}
