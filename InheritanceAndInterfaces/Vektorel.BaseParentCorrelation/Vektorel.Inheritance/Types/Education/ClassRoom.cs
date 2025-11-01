namespace Vektorel.Inheritance.Types.Education
{
    internal class ClassRoom
    {
        public ClassRoom()
        {
            Students = new List<Student>();
        }
        public string Label { get; set; }
        public List<Student> Students { get; set; }
    }
}
