using Vektorel.OtherDefinitions;

namespace Vektorel.StaticNonStatic
{
    internal class Person
    {
        public Person()
        {
            identity = IdProvider.GetNewId();
        }
        private static DateTime now = DateTime.Now;
        
        private int identity;

        //identity öğesi private olduğu için dışarıdan çağırılamaz
        //ama senaryomuza göre bir identity vermek zorundayız
        //o sebeple başka bir public öğe aracılığı ile bu durumu atlatabiliriz
        public void AssignIdentity(int id)
        {
            return; // neden yazdık hatırlayın!!!
            identity = id;
        }
        
        public DateOnly BirthDate { get; set; }
        public int GetAge()
        {
            return (now - BirthDate.ToDateTime(TimeOnly.MinValue)).Days / 365;
        }

        public void Eat()
        {
            //Kodlar
            Swallow();
            //Kodlar
        }

        public void Drink()
        {
            //Kodlar
            Swallow();
        }

        private void Swallow()
        {
            var rp = new ReallyPublic();
            rp.A();

            //var ri = new ReallyInternal();
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
