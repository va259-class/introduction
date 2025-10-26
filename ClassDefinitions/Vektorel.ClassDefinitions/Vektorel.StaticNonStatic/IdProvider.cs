namespace Vektorel.StaticNonStatic
{
    //static bir class'ın tüm öğeleri static olmak zorundadır
    internal static class IdProvider
    {
        static IdProvider()
        {
            id = 99;    
        }

        private static int id;

        public static int GetNewId()
        {
            return ++id;
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
