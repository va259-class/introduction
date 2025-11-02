using Vektorel.Interfaces.Abstractions;

namespace Vektorel.Interfaces.Concretes
{
    internal sealed class English : Person, ISpeakable
    {
        public override void Love()
        {
            Console.WriteLine("I love you");
        }

        public string SayHi()
        {
            return "Hi";
        }

        public void Speak(string thingsToSpeak)
        {
            Console.WriteLine($"I said {thingsToSpeak} in English");
        }
    }

    //sealed class inherit edilemez
    //internal class Scottish : English
    //{

    //}
}
