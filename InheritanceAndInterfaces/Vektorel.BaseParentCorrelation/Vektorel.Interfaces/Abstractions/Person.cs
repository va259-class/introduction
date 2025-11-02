namespace Vektorel.Interfaces.Abstractions
{
    internal abstract class Person : IAlive
    {
        public string FullName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public void Breath()
        {
            Console.WriteLine("huh");
        }

        public abstract void Love();
    }
}
