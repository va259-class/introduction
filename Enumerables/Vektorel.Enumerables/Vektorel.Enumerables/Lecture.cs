namespace Vektorel.Enumerables
{
    class Lecture
    {
        public Lecture(string name, byte credit, byte courseCount)
        {
            Name = name;
            Credit = credit;
            CourseCount = courseCount;
        }
        public string Name { get; set; }
        public byte Credit { get; set; }
        public byte CourseCount { get; set; }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj is Lecture comparedLecture)
            {
                return comparedLecture.Name == Name;
            }
            return false;
        }
    }
}
