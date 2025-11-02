namespace Vektorel.Interfaces.Abstractions
{
    internal abstract class Person
    {
        public string FullName { get; set; }

        public void Breath()
        {
            Console.WriteLine("huh");
        }
    }
}
