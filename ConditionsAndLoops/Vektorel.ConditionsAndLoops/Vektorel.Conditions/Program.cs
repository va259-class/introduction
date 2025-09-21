namespace Vektorel.Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STEP 1
            //var isEven = 10 % 2 == 0; // MOD ALMA İŞLEMİ
            //if (!isEven)
            //{
            //    Console.WriteLine("İşlem tek");
            //}

            //STEP 2
            //var isAccepted = false;

            //if (isAccepted == true)
            //{
            //    Console.WriteLine("Bu sözleşmeyi kabul ettim");
            //}
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bu sözleşmeyi kabul ederek bu sözleşmeyi kabul etmiş sayılıyorum.");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Sözleşmeyi kabul ediyor musunuz? (E/H)");
            Console.ForegroundColor = ConsoleColor.White;
            var acceptedChar = Console.ReadLine();
            if (acceptedChar == "e" || acceptedChar == "E")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Üyeliğiniz onaylanmıştır!");
            }
            else if (acceptedChar == "h" || acceptedChar == "H")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Üyeliğiniz onaylanmamıştır!");
            }
            else
            {
                Console.WriteLine("Onayınızı alınamadı! Tekrar deneyiniz...");
            }

            Console.ReadKey(); // Bir tuşa basana kadar bekle
        }
    }
}
