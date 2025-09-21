namespace Vektorel.Iterations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TEKER TEKER SAYARAK 3'E TAM BÖLÜNEN SAYILARI YAZDIRAN DÖNGÜ
            for (int n = 0; n < 30; n++)
            {
                if (n % 3 == 0)
                {
                    Console.Write(n + " - ");
                }
            }
            Console.WriteLine();
            //3'ERLİ SAYARAK SAYILARI EKRANA YAZDIRAN DÖNGÜ
            for (int n = 0; n < 30; n = n + 3)
            {
                Console.Write(n + " - ");
            }
            Console.WriteLine();
            Console.WriteLine("Negatif Sayıları Hesaba Katmayan Adım");
            var positiveSum = 0;
            for(var i = 0; i < 10; i++)
            {
                Console.Write(i + 1 + "/10 - Sayı Giriniz ");
                var number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    continue; // DÖNGÜYÜ SÜRDÜR
                }
                positiveSum += number;
            }
            Console.WriteLine("Pozitif Sayıların Toplamı..: " + positiveSum);

            Console.WriteLine("Negatif Sayı Girmeyi Sonradan Düşün");
            // NEGATİF SAYI GİRENE KADAR ÇALIŞAN DÖNGÜ (MAX 20 SAYI ALIR)
            for (int i = 0; i < 20; i++)
            {
                Console.Write(i + 1 + "/20 - Sayı Giriniz ");
                var number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    break; // DÖNGÜDEN ÇIK!
                }
            }

            Console.WriteLine("Şimdi 5 sayı toplamı yapılacak");

            var sum = 0;
            //GİRİLEN 5 SAYIYI TOPLAYAN DÖNGÜ
            for (var i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + "/5 - Sayı Giriniz ");
                var number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }

            Console.WriteLine("Sayıların Toplamı: " + sum);
        }
    }
}


/*
 var i = 10;
 ++i; => 11
 --i; => 10
 i++; => 11
 i--; => 10
 i = i + 1; => 11
 i = i - 1; => 10
 i = i + 4; => 14
 i = i - 5; => 9
 i += 5; => 14
 i -= 3; => 11
 */