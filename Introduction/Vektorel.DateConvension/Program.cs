namespace Vektorel.DateConvension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Doğum Tarihiniz....: ");
            var birthDate = DateTime.Parse(Console.ReadLine());
            var today = DateTime.Now;
            var difference = today - birthDate;
            //TimeSpan difference = today - birthDate;
            var rawAge = difference.Days / 365;
            var days = difference.Days - (rawAge * 365);
            Console.WriteLine("Yaşınız " + rawAge);
            Console.WriteLine("Ekstra Bilgi : " + days + " gün, " + difference.Hours + " saat, " + difference.Minutes + " dakika");

            // Değişken tanımlama yöntemleri (type vs var)
            int b = 1;          //System.Int32 b = 1;
            int d = 4;          //System.Int32 d = 4;
            int sum1 = b + d;   //System.Int32 sum1 = b + d;

            var a = 1;          //System.Int32 a = 1;
            var c = 4;          //System.Int32 c = 1;
            var sum2 = a + c;   //System.Int32 sum2 = a + c;
        }
    }
}
