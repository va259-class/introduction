// IEnumerable
namespace Vektorel.TicketManagement2
{
    internal class Program
    {
        static List<Bus> buses = new List<Bus>();
        static void Main(string[] args)
        {
            ShowWelcomeScreen();
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
                Console.WriteLine("Plaka : {0}", bus.Plate);
            }
            Console.ReadLine();
        }
        static void AddBus() 
        {
            Console.Clear();
            var bus = new Bus();
            Console.Write("Plaka Giriniz................: ");
            bus.Plate = Console.ReadLine();
            Console.Write("Koltuk Sayısı Giriniz........: ");
            bus.Capacity = byte.Parse(Console.ReadLine());
            bus.Create();
            buses.Add(bus);

            Console.WriteLine("Otobüs Eklendi");
            Console.ReadLine();
        }
        static void ListPassengers() 
        {
            Console.Clear();
            var bus = FindBus();
            if (bus == null)
            {
                return;
            }

            int index = 0;
            foreach (var passenger in bus.GetPassengers())
            {
                index++;
                if (passenger == null)
                {
                    Console.WriteLine("Koltuk : {0} - Yolcu : ---", index);
                    continue;
                }
                Console.WriteLine("Koltuk : {0} - Yolcu : {1}", index, passenger.FullName);
            }
            Console.ReadLine();
        }
        static void AddPassenger() 
        {
            Console.Clear();
            var bus = FindBus();
            if (bus == null)
            {
                return;
            }
            Console.Write("Koltuk Seçiniz.........: ");
            var seat = byte.Parse(Console.ReadLine());
            Console.Write("Yolcu Adı Soyadı.......: ");
            var fullName = Console.ReadLine();
            SetPassengers(bus, seat, fullName);
        }
        static void RemovePassenger() 
        {
            //list Remove methoduna bakınız
        }

        static Bus FindBus()
        {
            Console.Write("Yolcunun Kullanacağı Otobüs Plakası...: ");
            var plate = Console.ReadLine();
            //return buses.Find(x => x.Plate == plate); // İLERİDE :D
            foreach (var bus in buses)
            {
                if (bus.Plate == plate)
                {
                    return bus;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Plakadan otobüs bulunamadı!");
            Console.ReadLine();
            return null;
        }

        static void SetPassengers(Bus bus, byte seat, string fullName)
        {
            var p = new Passenger();
            p.FullName = fullName;
            bus.Register(p, seat);
        }
    }
}
