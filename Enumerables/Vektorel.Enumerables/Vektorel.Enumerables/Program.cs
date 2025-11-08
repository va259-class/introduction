namespace Vektorel.Enumerables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            var names = new List<string> { "Can", "Furkan", "Eda", "Bilge", "Kenan", "Asya" };
            var uniqueNumbers = new HashSet<int> { 1, 2, 3, 4, 1, 3, 5, 2, 2, 8, 1 };
            var sortedNumbers = new SortedSet<int> { 4, 6, 1, 9, 2, 6, 7, 1, 3, 2, 8 };
            var definitions = new Dictionary<int, string>
            {
                { 1, "Bir" },
                { 2, "İki" },
                { 3, "Üç" },
                { 4, "Dört" }
            };

            var plates = new Dictionary<string, string>
            {
                { "01", "Adana" },
                { "02", "Adıyaman" },
                { "03", "Afyon" },
                { "04", "Ağrı" },
                { "05", "Amasya" },
                { "06", "Ankara" },
                //{ "06", "Polatlı" }
            };
            var p1 = new Person { FullName = "Can Perk", Identity = "124" };
            var people = new HashSet<Person>
            {
                p1
            };

            var t1 = new Team("Galatasaray", 1905);
            var teams = new HashSet<Team>
            {
                t1
            };
            p1.FullName = "Furkan Kaymak";

            foreach (var df in plates)
            {
                Console.WriteLine(df.Value);
            }
            Console.WriteLine();

            foreach (var n in sortedNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("----------------");

            var lectures = new HashSet<Lecture>
            {
                new Lecture("Türkçe", 4, 28),
                new Lecture("Coğrafya", 1, 12),
                new Lecture("Matematik", 3, 22),
                new Lecture("Tarih", 2, 14),
                new Lecture("Kimya", 3, 20),
                new Lecture("Kimya", 7, 38),
                new Lecture("Türkçe", 4, 28),
            };

            foreach (var lc in lectures)
            {
                Console.WriteLine("{0, -10} - {1,2} saatte {2,2} kredi", lc.Name, lc.CourseCount, lc.Credit);
            }
        }
    }

    struct Person
    {
        public string Identity { get; set; }
        public string FullName { get; set; }
    }
    // record da bir struct'tır
    record Team(string Name, int Year);
}
