namespace Vektorel.Sample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sepetteki Meyve Çeşidi Adedi...: ");
            var count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=================================");
            var total = 0D;

            for (int i = 0; i < count; i++)
            {
                Fruit f = new Fruit();
                Console.Write("Meyve Giriniz...........: ");
                f.name = Console.ReadLine();
                Console.Write("Alım Miktarı Giriniz....: ");
                f.amount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Fiyatı Giriniz..........: ");
                f.price = Convert.ToDouble(Console.ReadLine());
                total += f.GetTotal();
                Console.WriteLine();
            }

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
