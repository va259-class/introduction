using Vektorel.RealLifeInterfaceSample1.Interfaces;

namespace Vektorel.RealLifeInterfaceSample1.Entities
{
    internal class Message : ITrackable
    {
        public Message(string user)
        {
            CreatedAt = DateTime.Now;
            ModifiedAt = DateTime.Now;
            CreatedBy = user;
            ModifiedBy = user;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsRead { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
    }
}
