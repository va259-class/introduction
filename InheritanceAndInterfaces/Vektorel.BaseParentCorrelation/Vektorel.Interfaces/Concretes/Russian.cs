using Vektorel.Interfaces.Abstractions;

namespace Vektorel.Interfaces.Concretes
{
    internal class Russian : Person, ISpeakable
    {
        public string SayHi()
        {
            return "Привет!";
        }

        public void Speak(string thingsToSpeak)
        {
            Console.WriteLine($"Я сказал {thingsToSpeak} по Русский");
        }
    }
}
