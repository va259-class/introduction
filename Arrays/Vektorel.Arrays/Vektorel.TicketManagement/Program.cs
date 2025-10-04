namespace Vektorel.TicketManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bus1 = new Bus();
            bus1.Plate = "06 M 8090";
            bus1.Capacity = 10;
            bus1.Create();

            SetPassengers(bus1, 1, "Can");
            SetPassengers(bus1, 2, "Rana");
            SetPassengers(bus1, 3, "Osman");
            // Validasyona takıldığı için yerleştirilemedi
            SetPassengers(bus1, 1, "Edanur");

            var bus2 = new Bus();
            bus2.Plate = "06 M 2020";
            bus2.Capacity = 8;
            bus2.Create();

            SetPassengers(bus2, 5, "Kenan");
            SetPassengers(bus2, 4, "Taha Can");
            SetPassengers(bus2, 1, "Ömer");

            Print(bus1);
            Console.WriteLine();
            Print(bus2);
        }

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
    }
}
