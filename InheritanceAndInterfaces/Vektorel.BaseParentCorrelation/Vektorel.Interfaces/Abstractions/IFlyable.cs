namespace Vektorel.Interfaces.Abstractions
{
    internal interface IFlyable
    {
        public int Speed { get; set; }
        public void Fly(int x, int y);
    }
}
