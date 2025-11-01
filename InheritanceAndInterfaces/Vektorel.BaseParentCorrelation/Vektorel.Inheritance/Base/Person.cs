using Vektorel.Inheritance.Enums;

namespace Vektorel.Inheritance.Base
{
    // abstraction: soyutluk
    //abstract bir tip tek başına bir şey ifade etmemeli
    //bir şey ifade etmediği için de abstract işaretlenmeli ki
    //yanlışlıkla da olsa instance oluşmasın
    internal abstract class Person
    {
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateOnly BirthDate { get; set; }
        //Sonradan eklendi
        public int IdentityNumber { get; set; }
        public int Age 
        { 
            get
            {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
    }
}
