using System.Text;
using Vektorel.Libraries.Abstractions;

namespace Vektorel.Libraries.Models
{
    public class ChildBook : Book, IBorrowable
    {
        public bool HasColors { get; set; }
        public bool? Paintable { get; set; }

        public override string GetIntroduction()
        {
            var builder = new StringBuilder();
            builder.Append($"{Title}, {Author.Name} tarafından yazılmış, birbirinden eğlenceli {PageCount} sayfası olan");
            if (HasColors)
            {
                builder.Append(" rengarenk sayfalı");
            }
            else
            {
                builder.Append(" hayal gücüne bırakılan siyah beyaz çizgili");
            }

            if (Paintable.HasValue && Paintable.Value)
            {
                builder.Append(" ve dilediğince boyayabileceğin");
            }

            builder.Append(" bir kitaptır. İyi okumalar dileriz sevgili minik kahraman!");
            return builder.ToString();
        }
    }
}
