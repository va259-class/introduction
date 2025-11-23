using Vektorel.Libraries.Abstractions;

namespace Vektorel.Libraries.Helpers
{
    public class LibraryHelper
    {
        private List<Book> books;

        public LibraryHelper()
        {
            books = new List<Book>();
        }

        public void Add(Book book)
        {
            books.Add(book);
        }

        public void GetAllInformations()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.GetIntroduction());
            }
        }
    }
}
