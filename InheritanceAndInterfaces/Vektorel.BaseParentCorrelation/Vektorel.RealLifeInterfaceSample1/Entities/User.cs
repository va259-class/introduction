using Vektorel.RealLifeInterfaceSample1.Interfaces;

namespace Vektorel.RealLifeInterfaceSample1.Entities
{
    internal class User : ITimeAuditable
    {
        public User()
        {
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
