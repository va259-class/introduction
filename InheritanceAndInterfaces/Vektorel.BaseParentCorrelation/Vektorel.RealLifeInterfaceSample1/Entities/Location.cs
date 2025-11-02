using Vektorel.RealLifeInterfaceSample1.Interfaces;

namespace Vektorel.RealLifeInterfaceSample1.Entities
{
    internal class Location : ICreatedBy
    {
        public string Name { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string CreatedBy { get; set; }
    }
}
