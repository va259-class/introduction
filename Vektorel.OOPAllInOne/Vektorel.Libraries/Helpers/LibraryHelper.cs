using Vektorel.Libraries.Abstractions;

namespace Vektorel.Libraries.Helpers
{
    public class LibraryHelper
    {
        private Dictionary<int, string> borrowList;
        private List<Book> books;

        public LibraryHelper()
        {
            books = new List<Book>();
            borrowList = new Dictionary<int, string>();
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

        public void BorrowBook(IBorrowable book, string phone)
        {
            var hash = book.GetHashCode();
            var b = book as Book;
            if (borrowList.ContainsKey(hash))
            {
                Console.WriteLine($"{b.Title} zaten alınmış");
                return;
            }

            borrowList.Add(hash, phone);
            Console.WriteLine($"{b.Title} {phone} tarafından ödünç alındı");
        }

        public void Return(IBorrowable book)
        {
            var hash = book.GetHashCode();
            var b = book as Book;
            if (borrowList.ContainsKey(hash))
            {
                borrowList.Remove(hash);
                Console.WriteLine($"{b.Title} teslim alındı");
                return;
            }

            Console.WriteLine($"{b.Title} zaten ödünç alınmamış.");
        }
    }
}
