namespace Vektorel.CompareItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new Person[10];
            persons[0] = new Person();
            persons[0].Name = "Can Perk";
            persons[0].BirthDate = new DateOnly(1988, 2, 8);
            persons[0].Gender = Gender.Male;

            persons[1] = new Person();
            persons[1].Name = "Aylin Yıldız";
            persons[1].BirthDate = new DateOnly(1997, 12, 14);
            persons[1].Gender = Gender.Female;

            persons[2] = new Person();
            persons[2].Name = "Murat Kaya";
            persons[2].BirthDate = new DateOnly(1991, 3, 20);
            persons[2].Gender = Gender.Male;

            persons[3] = new Person();
            persons[3].Name = "Perihan Işık";
            persons[3].BirthDate = new DateOnly(1993, 7, 12);
            persons[3].Gender = Gender.Female;

            persons[4] = new Person();
            persons[4].Name = "Cüneyt Demir";
            persons[4].BirthDate = new DateOnly(1994, 10, 7);
            persons[4].Gender = Gender.Male;

            persons[5] = new Person();
            Console.Write("Adı Soyadı.......: ");
            persons[5].Name = Console.ReadLine();
            Console.Write("Doğum Tarihi.....: ");
            persons[5].BirthDate = DateOnly.Parse(Console.ReadLine());
            Console.Write("Cinsiyeti........: ");
            persons[5].Gender = Enum.Parse<Gender>(Console.ReadLine());

            //persons array'inde dolaş ve her seferinde bir sonrakine otomatik olarak geç
            Person oldest = null;
            foreach(var person in persons)
            {
                if(person == null)
                {
                    break; // çık
                }
                Console.WriteLine(person.Name);
                var age = DateTime.Now.Year - person.BirthDate.Year;
                Console.WriteLine("Yaş : " + age);

                if (oldest == null)
                {
                    oldest = person;
                    continue;
                }

                if (person.BirthDate < oldest.BirthDate)
                {
                    oldest = person;
                }
            }

            Console.WriteLine("Verilen kişi listesine göre en büyük kişi " + oldest.BirthDate.Year + " yılında doğan " + oldest.Name);

            #region for muadili
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    var person = persons[i];
            //} 
            #endregion
        }
    }

    class Person
    {
        public string Name;
        public DateOnly BirthDate;
        public Gender Gender;
    }

    enum Gender
    {
        Male,
        Female
    }
}
