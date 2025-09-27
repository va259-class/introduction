namespace Vektorel.Sample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var total = 0D;
            Fruit f1 = new Fruit();
            Console.Write("Meyve Giriniz...........: ");
            f1.name = Console.ReadLine();
            Console.Write("Alım Miktarı Giriniz....: ");
            f1.amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fiyatı Giriniz..........: ");
            f1.price = Convert.ToDouble(Console.ReadLine());

            total += f1.GetTotal();
            Console.WriteLine();

            Fruit f2 = new Fruit();
            Console.Write("Meyve Giriniz...........: ");
            f2.name = Console.ReadLine();
            Console.Write("Alım Miktarı Giriniz....: ");
            f2.amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fiyatı Giriniz..........: ");
            f2.price = Convert.ToDouble(Console.ReadLine());
            
            total += f2.GetTotal();
            Console.WriteLine();

            Fruit f3 = new Fruit();
            Console.Write("Meyve Giriniz...........: ");
            f3.name = Console.ReadLine();
            Console.Write("Alım Miktarı Giriniz....: ");
            f3.amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Fiyatı Giriniz..........: ");
            f3.amount = Convert.ToDouble(Console.ReadLine());

            total += f3.GetTotal();

            Console.WriteLine("Toplam Fiyat " + total);
        }
    }

    class Fruit
    {
        public string name; // adı
        public double amount; // miktarı
        public double price; // fiyatı

        public double GetTotal()
        {
            //  !*!*!*!*!*!*!*!* ÖNEMLİ !*!*!*!*!*!*!*!*

            // BİR FONKSİYONUN DÖNÜŞ TÜRÜ VARSA (void değilse)
            // O FONKSİYON KESİNLİKLE BİR DEĞER DÖNMELİ
            return amount * price;
        }
    }
}
