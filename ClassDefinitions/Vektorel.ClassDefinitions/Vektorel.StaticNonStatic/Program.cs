namespace Vektorel.StaticNonStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static class instance'ı alınamaz!!!!!!
            //var ip = new IdProvider();

            var p1 = new Person();
            p1.Eat();
            p1.Drink();
            //Hack Yöntem:
            p1.AssignIdentity(100);
            p1.AssignIdentity(101);
            Console.WriteLine(p1.GetAge());

            var p2 = new Person();
            Console.WriteLine(p1.GetAge());
        }
    }
}

/*
 ACCESS MODIFIERS:

public: Öğenin "dışarıdan" çağırılacağını gösterir.
private: Öğenin "yalnızca" kendi tanım scope'unda erişilmesini belirler.
internal: Öğenin "yalnızca" kendi library'sinden erişilebileceğini belirtir.
protected: Öğenin "yalnızca" kendisinden "türetilen" alt "tiplerden" erişileceğini belirler.
protected internal: internal ve protected kesişimi

 */
