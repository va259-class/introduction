namespace Vektorel.StaticMethodSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a1 = new Account { Name = "Şahsi", Balance = 10000, Currency = Currency.TRY };
            var a2 = new Account { Name = "Müşterek", Balance = 600, Currency = Currency.USD };
            var a3 = new Account { Name = "Firma", Balance = 800, Currency = Currency.EUR };
            var a4 = new Account { Name = "Yatırım", Balance = 14000, Currency = Currency.TRY };

            Account.GetInformation(a1);
            Account.GetInformation(a2);
            Account.GetInformation(a3);
            Account.GetInformation(a4);

            Console.WriteLine();

            Account.Merge(a1, a2);
            Account.GetInformation(a1);
            Account.GetInformation(a2);

            Console.WriteLine();

            Account.Merge(a1, a4);
            Account.GetInformation(a1);
            Account.GetInformation(a4);
        }
    }

    class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public Currency Currency { get; set; }

        public static void GetInformation(Account account)
        {
            Console.WriteLine("{0} hesabında {1} {2} bakiye mevcut", 
                               account.Name, 
                               account.Balance, 
                               account.Currency);
        }

        public static void Merge(Account current, Account from)
        {
            if (current.Currency != from.Currency)
            {
                Console.WriteLine("Kur farkı sebepli işlem gerçekleştirilemedi");
                return;
            }

            if (from.Balance <= 0)
            {
                Console.WriteLine("Hesap müsait değil");
                return;
            }

            current.Balance += from.Balance;
            from.Balance = 0;

            Console.WriteLine("Hesaplar birleştirildi!");
        }
    }

    enum Currency
    {
        USD,
        EUR,
        TRY
    }
}
