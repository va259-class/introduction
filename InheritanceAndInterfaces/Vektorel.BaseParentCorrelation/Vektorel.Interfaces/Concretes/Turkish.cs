using Vektorel.Interfaces.Abstractions;

namespace Vektorel.Interfaces.Concretes
{
    internal class Turkish : Person, ISpeakable
    {
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
