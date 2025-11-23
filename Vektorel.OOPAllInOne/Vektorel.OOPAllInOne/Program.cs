using Vektorel.Libraries.Models;

namespace Vektorel.OOPAllInOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Author("Fyodor Dostoyevski");
            var a2 = new Author("Franz Kafka");
            var a3 = new Author("Astrid Lindgren");
            
            var b1 = new Novel();
            b1.Title = "Karamazov Kardeşler";
            b1.Author = a1;
            b1.PageCount = 892;

            var b2 = new HandwritedBook();
            b2.Title = "Milenaya Mektuplar";
            b2.PageCount = 62;
            b2.Author = a2;

            var b3 = new ChildBook();
            b3.Title = "Pippi";
            b3.HasColors = true;
            b3.Paintable = true;
            b3.PageCount = 26;
            b3.Author = a3;

            Console.WriteLine(b1.GetIntroduction());
            Console.WriteLine(b2.GetIntroduction());
            Console.WriteLine(b3.GetIntroduction());
        }
    }
}
