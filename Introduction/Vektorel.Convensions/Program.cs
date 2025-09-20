namespace Vektorel.Convensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Öncelikle ismini söyler misin? ");
            string input1 = Console.ReadLine(); // Satırda bekle, enter'a kadar dinle

            Console.WriteLine("Merhaba, " + input1);

            Console.WriteLine();

            Console.Write("Bir sayı gir...: ");
            int number = int.Parse(Console.ReadLine());
            
            int doubled = number * 2;

            Console.WriteLine("Bu sayının iki katı : " + doubled);

            Console.Write("Bir sayı daha gir...: ");
            int multiplier1 = int.Parse(Console.ReadLine());
            Console.Write("Son sayı daha gir...: ");
            int multiplier2 = Convert.ToInt32(Console.ReadLine());

            int result = multiplier1 * multiplier2;
            Console.WriteLine("Bu iki sayının çarpımı : " + result);
        }
    }
}
