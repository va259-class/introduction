namespace Vektorel.BasicArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num1 = 3;
            var num2 = 4;
            var num3 = 5;
            var num4 = 6;
            var num5 = 7;
            var num6 = 8;
            var num7 = 9;
            var num8 = 10;

            num5 = 12;

            var numbers = new int[]
            {
                3,4,5,6,7,8,9,10
            };

            numbers[4] = 12;// 4. index'te yazanı (yani 7) 12 yap

            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("Ekranı temizlemek için Enter'a basınız");
            Console.ReadLine();
            Console.Clear();
            var entryNumbers = new int[7]; // 5 sayı kapasiteli bir sayı dizisi
            Console.WriteLine("5 Adet Sayı Giriniz");

            for (var i = 0; i < entryNumbers.Length; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Giriniz.....: ");
                entryNumbers[i] = int.Parse(Console.ReadLine());
            }

            var max = 0;
            for (int i = 0; i < entryNumbers.Length; i++)
            {
                if (entryNumbers[i] > max)
                {
                    max = entryNumbers[i];
                }
            }

            Console.WriteLine("Girilen En Büyük Sayı :" + max);

            //Ödev
            var unOrderedNumbers = new int[]
            {
                12, 24, 1, 6, 98, 23, 6, 13, 25, 36, 8
            };

            // 1, 6, 6, 8, 12, 13, 24, 25, 36, 98
        }
    }
}
