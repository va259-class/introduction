namespace Vektorel.Interfaces.Abstractions
{
    internal interface IAlive
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public void Love();
    }
}
