using Vektorel.Libraries.Abstractions;
using Vektorel.Libraries.Enums;

namespace Vektorel.Libraries.Models
{
    public class Novel : Book
    {
        public NovelType Type { get; set; }
    }
}
