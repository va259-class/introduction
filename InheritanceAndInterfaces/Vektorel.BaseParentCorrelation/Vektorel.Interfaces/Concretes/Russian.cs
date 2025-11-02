using Vektorel.Interfaces.Abstractions;

namespace Vektorel.Interfaces.Concretes
{
    internal sealed class Russian : Person, ISpeakable
    {
        public override void Love()
        {
            Console.WriteLine("Я тебя люблю");
        }

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
