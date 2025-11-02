using System.Text;
using Vektorel.Interfaces.Concretes;

namespace Vektorel.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //var p = new Person();
            var t = new Turkish
            {
                FullName = "Can Perk"
            };
            var e = new English
            {
                FullName = "John Smith"
            };
            var r = new Russian
            {
                FullName = "Владимрь Путин"
            };

            t.Breath();
            Console.WriteLine(t.SayHi());
            t.Speak("gunaydin herkese");
            t.Run(6, 9);

            e.Breath();
            Console.WriteLine(e.SayHi());
            e.Speak("gunaydin herkese");
            
            r.Breath();
            Console.WriteLine(r.SayHi());
            r.Speak("gunaydin herkese");
        }
    }
}
