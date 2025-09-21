namespace Vektorel.ForLoopSample
{
    class Membership
    {
        string fullName;
        DateTime issuedAt;
        Status status;
        bool isRegistered = false;

        public void Register(string name)
        {
            fullName = name;
            issuedAt = DateTime.Now;
            status = Status.Waiting;
            isRegistered = true;
        }

        public void PrintStatus()
        {
            Console.WriteLine();
            if (!isRegistered)
            {
                Console.WriteLine("Üye kayıt işlemi yapılmalı!");
                Console.WriteLine();
                return; // Methodtan ÇIK!
            }
            Console.WriteLine("Üye Bilgisi:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Adı Soyadı....: " + fullName);
            Console.WriteLine("Durumu........: " + status);
            Console.WriteLine();
        }

        public void Accept()
        {
            if (status == Status.Accepted)
            {
                return;
            }
            status = Status.Accepted;
        }

        public void Reject()
        {
            if (status == Status.Rejected)
            {
                return;
            }
            status = Status.Rejected;
        }

        /*
         Kampanya kullanma koşulu:
            1. Üyeliği kabul edecek
            2. Kayıt Tarihi 10 saniye önce olacak
         */
        public void UseCampaign()
        {
            Console.WriteLine(fullName + " kullanıcısı için; ");
            if (status != Status.Accepted)
            {
                Console.WriteLine("Üyeliği onaylanmayan kullanıcı kampanyadan faydalanamaz");
                return;
            }

            var duration = DateTime.Now - issuedAt;
            if (duration.TotalSeconds < 10)
            {
                Console.WriteLine("Yeni üyeler kampanyadan faydalanamaz");
                return;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("%10 kampanya indiriminiz aktif");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    enum Status
    {
        Accepted,
        Rejected,
        Waiting
    }
}
