namespace Vektorel.TicketManagement
{
    internal class Program
    {
        static int busIndex = 0;
        static Bus[] buses = new Bus[4];
        static void Main(string[] args)
        {
            ShowWelcomeScreen();
        }

        /// <summary>
        /// Tanımlı bir otobüsün seçili koltuğuna yolcu yerleştirmek için kullanılır
        /// </summary>
        /// <param name="bus">önceden tanımlanmış otobüs</param>
        /// <param name="seat">koltuk numarası</param>
        /// <param name="fullName">yolcu adı ve soyadı</param>
        static void SetPassengers(Bus bus, byte seat, string fullName)
        {
            var p = new Passenger();
            p.FullName = fullName;
            bus.Register(p, seat);
        }

        static void Print(Bus bus)
        {
            Console.WriteLine(bus.Plate + " yolcu listesi\n");
            var index = 0;
            foreach (var passenger in bus.GetPassengers())
            {
                index++;
                if (passenger == null)
                {
                    continue;
                }
                Console.WriteLine("{0}. Koltuk - {1}", index, passenger.FullName);
                //Console.WriteLine(index + ". Koltuk - " + passenger.FullName);
            }
        }

        static void ShowWelcomeScreen()
        {
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("============== İŞLEM SEÇİNİZ ===============");
                Console.WriteLine(@"||    Araç Listesi................: 1     ||
||    Araç Ekle...................: 2     ||
||    Yolcu Listele...............: 3     ||
||    Yolcu Ekle..................: 4     ||
||    Yolcu Çıkar.................: 5     ||
============================================");
                var key = Console.ReadKey();
                Console.Clear();
                //if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                //{
                //    ListBuses();
                //}
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        ListBuses();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        AddBus();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        ListPassengers();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        AddPassenger();
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        RemovePassenger();
                        break;
                    default:
                        Console.WriteLine("İşlem Tanınmadı");
                        Console.ReadLine();
                        break;
                }
            } while (true);
        }

        static void ListBuses()
        {
            Console.Clear();
            Console.WriteLine("OTOBÜS LİSTESİ");
            foreach (var bus in buses)
            {
                if (bus == null)
                {
                    continue;
                }
                Console.WriteLine("Plaka : {0}", bus.Plate);
            }
            Console.ReadLine();
        }

        static void AddBus()
        {
            Console.Clear();
            if (busIndex == buses.Length)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Garajda yeterli alan yok");
                Console.ReadLine();
                return;
            }
            var bus = new Bus();
            Console.Write("Plaka Giriniz................: ");
            bus.Plate = Console.ReadLine();
            Console.Write("Koltuk Sayısı Giriniz........: ");
            bus.Capacity = byte.Parse(Console.ReadLine());
            bus.Create();
            buses[busIndex++] = bus;

            Console.WriteLine("Otobüs Eklendi");
            Console.ReadLine();
        }

        static void ListPassengers()
        {

        }

        static void AddPassenger()
        {

        }

        static void RemovePassenger()
        {

        }
    }
}
