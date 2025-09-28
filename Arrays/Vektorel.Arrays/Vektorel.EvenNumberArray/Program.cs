namespace Vektorel.EvenNumberArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sadece Çift Sayıların Girilmesini İsteyen Uygulama
            var evenNumbers = new int[10];
            
            Console.WriteLine("10 Adet Çift Sayı Girmelisiniz");
            var order = 1;
            while (true)
            {
                Console.Write(order + ". Sayı....: ");
                var number = int.Parse(Console.ReadLine());
                if (number % 2 == 0) // Sayı çift ise
                {
                    evenNumbers[order - 1] = number;
                    order++;
                    if (order == 11)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("10 Adet Sayı Girişi Tamamlandı!");
        }
    }
}
