namespace Vektorel.LoopKinds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Döngüsü ile:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("While Döngüsü ile:");
            int wi = 0;
            while (wi < 10)
            {
                Console.WriteLine(wi);
                wi++;
            }
            Console.WriteLine();
            Console.WriteLine("Do Döngüsü ile:");
            var di = 0;
            do
            {
                Console.WriteLine(di);
            } while (++di < 10);

            Console.WriteLine("ForEach Döngüsü ile:");
            Console.WriteLine("to be continued...");

            var c = 4;
            var d = c++ + 4;
            var e = ++d + 3;

            var b = e * d;
            // B = 108 çıkar... Teyit Et!!!
        }
    }
}
