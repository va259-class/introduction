using Vektorel.Introduction.Can;

namespace Vektorel.Introduction
{
    class Program
    {
        static void Main(string[] args) // Main methodu (iş yapılan yer)
        {
            //PRIMITIVE TYPES
            int number1 = 300;
            int number2 = 400;
            int sum = number1 + number2; // 700

            string numberLike1 = "300";
            string name = "Can Perk";

            // PRIMITIVE & COMPLEX
            string numberLikeSum1 = numberLike1 + number2; //300400
            bool has = true; // false
            byte b = 123;
            char oneCharacter = 'C';
            // number1 != numberLike1

            //COMPLEX TYPES
            Account myAccount = new Account();
            myAccount.createdAt = new DateTime(2024, 12, 6);
            myAccount.name = "Birikim Hesabı";
            myAccount.currency = Currency.USD;
            myAccount.balance = 32064;

            Account yourAccount = new Account();
            myAccount.createdAt = new DateTime(2023, 8, 23);
            myAccount.name = "Yatırım Hesabı";
            myAccount.currency = Currency.EUR;
            myAccount.balance = 167200;

            Person p = new Person();


        }
    }

    class Account
    {
        public string name; // metin tipi
        public DateTime createdAt; // tarih tipi
        public decimal balance; // ondalıklı sayı tipi *
        public Currency currency; // özel tip
    }

    enum Currency
    {
        TRY,
        USD,
        EUR
    }
}

namespace Vektorel.Introduction.Can
{
    class Person
    {

    }
}

// IL : Intermediate Language
// JIT: Just In Time Compiler


/*
C# içinde kullanacağımız ana yapılar
class
struct
enum
interface
event
delaget
*/