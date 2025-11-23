namespace Vektorel.Libraries.Models
{
    public class Book
    {
        public int PageCount { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }

        public string GetIntroduction()
        {
            return $"{Author.Name} kaleminden yazılan {Title} kitabı {PageCount} sayfadır";
        }
    }

    public class Author
    {
        public Author(string name)
        {
            Name = name;
        }
        public string Name { get; }
    }
}
