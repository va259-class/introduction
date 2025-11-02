using Vektorel.Interfaces.Abstractions;

namespace Vektorel.Interfaces.Concretes
{
    internal class English : Person, ISpeakable
    {
        public string SayHi()
        {
            return "Hi";
        }

        public void Speak(string thingsToSpeak)
        {
            Console.WriteLine($"I said {thingsToSpeak} in English");
        }
    }
}
