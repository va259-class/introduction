namespace Vektorel.ForLoopSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + 1 + "/10 - Üye Girişi ");

                Console.Write("Üye Adı Soyadı.....: ");
                var fullName = Console.ReadLine();
                var member = new Membership();
                member.Register(fullName);

                if (i % 3 == 0)
                {
                    member.Accept();
                }
                else if (i % 7 == 0)
                {
                    member.Reject();
                }

                member.PrintStatus();
            }
        }
    }
}
