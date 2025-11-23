using Vektorel.Libraries.Models;

namespace Vektorel.Libraries.Abstractions
{
    public abstract class Book
    {
        public int PageCount { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public virtual string GetIntroduction()
        {
            return $"{Author.Name} kaleminden yazılan {Title} kitabı {PageCount} sayfadır";
        }
    }
}
