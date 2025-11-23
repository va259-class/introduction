using Vektorel.Libraries.Models;

namespace Vektorel.OOPAllInOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Author("Fyodor Dostoyevski");
            
            var b1 = new Book();
            b1.Title = "Karamazov Kardeşler";
            b1.Author = a1;
            b1.PageCount = 892;

            Console.WriteLine(b1.GetIntroduction());
        }
    }
}
