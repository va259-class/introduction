namespace Vektorel.DoSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HardWorker mesaj numarasını 650 - 700 arasında vermezse
            //ilgili işlem yapılamaz.
            // COOL YÖNTEM
            var hw = new HardWorker();
            var value = 0;
            do
            {
                if (value != 0) // id 0 değilse
                {
                    Console.WriteLine("Referans yeniden kontrol ediliyor");
                }
                Thread.Sleep(300);
                value = hw.GetReferenceValue();
                Console.WriteLine("Referans Değeri : " + value);
            } while (hw.IsOutOfReference(value));
            hw.DoWork();

            //-----------------------------------------------
            // KEKO YÖNTEM
            while (true)
            {
                var id = Random.Shared.Next(1, 1000);
                Console.WriteLine("Referans değeri " + id);
                if(id > 650 && id < 700)
                {
                    Console.WriteLine("İşlem başladı");
                    Thread.Sleep(1500);// Gerçek manada çalışan bir iş 
                    Console.WriteLine("İşlem tamamlandı");
                    break;
                }
                Thread.Sleep(300);
                Console.WriteLine("İşlem yeniden kontrol ediliyor");
            }
        }
    }

    class HardWorker
    {
        public int GetReferenceValue()
        {
            return Random.Shared.Next(1, 1000); // Rasgele sayı üret
        }

        public bool IsOutOfReference(int value)
        {
            return value < 650 || value > 700;
        }

        public void DoWork()
        {
            Console.WriteLine("İşlem başladı");
            //miş gibi yapılan iş
            Thread.Sleep(1500); // 1.5 saniye uygulamayı duraklat
            Console.WriteLine("İşlem tamamlandı");
        }
    }
}
