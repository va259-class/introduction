using Vektorel.Interfaces.Abstractions;

namespace Vektorel.Interfaces.Concretes
{
    internal class Turkish : Person, ISpeakable, IRunnable
    {
        public void Run(int x, int y)
        {
            Console.WriteLine($"İstikamet alıp {x} - {y} koordinatına koştum");
        }

        public string SayHi()
        {
            return "Merhaba";
        }

        public void Speak(string thingsToSpeak)
        {
            Console.WriteLine($"Türkçe olarak {thingsToSpeak} dedim mesela");
        }
    }
}
