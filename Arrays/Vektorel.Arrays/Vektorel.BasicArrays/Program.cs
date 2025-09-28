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
            Console.WriteLine("5 Adet Sayı Giriniz");
            Console.Write("1. Sayıyı Giriniz.....: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz.....: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz.....: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("4. Sayıyı Giriniz.....: ");
            num4 = int.Parse(Console.ReadLine());
            Console.Write("5. Sayıyı Giriniz.....: ");
            num5 = int.Parse(Console.ReadLine());

            #region Onlardan Olma!
            if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                Console.WriteLine("En Büyük " + num1);
            }
            if (num2 > num3 && num2 > num4 && num2 > num5)
            {
                Console.WriteLine("En Büyük " + num2);
            }
            if (num3 > num4 && num3 > num5)
            {
                Console.WriteLine("En Büyük " + num3);
            }
            if (num4 > num5)
            {
                Console.WriteLine("En Büyük " + num4);
            }
            #endregion


        }
    }
}
