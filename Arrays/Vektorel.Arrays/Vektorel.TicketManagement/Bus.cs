namespace Vektorel.TicketManagement
{
    class Bus
    {
        public string Plate;
        public byte Capacity;
        private Passenger[] passengers;
        public void Create()
        {
            passengers = new Passenger[Capacity];
        }

        public void Register(Passenger passenger, byte seat)
        {
            //Create fonksiyonu çağrılmayan bus örnekleri için kontrol işlemi
            if (passengers == null)
            {
                return;
            }

            // Aynı koltuğu atamamak için
            if (passengers[seat - 1] != null)
            {
                return;
            }

            passengers[seat - 1] = passenger;
        }

        // içeride tuttuğumuz yolcuları dışarıdan çağırdığımızda paylaşmak için kullanılır
        public Passenger[] GetPassengers()
        {
            return passengers;
        }
    }
}
