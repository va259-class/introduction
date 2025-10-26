namespace Vektorel.StaticNonStatic.Sample.Models
{
    internal class Student
    {
        public Student(int number)
        {
            //Readonly bir property'e asla değer atanamaz!!!
            //Ancak aşağıda bu kuralı bozan bir durum söz konusu
            //İstisnai olarak, constructor, read only property'e değer yazabilir
            Number = number;
        }
        public int Number { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        private string city;
        public void SetCity(string value)
        {
            this.city = value;
        }
        public string GetCity()
        {
            return this.city;
        }

        private string className;
        public string ClassName
        {
            get
            {
                return this.className;
            }
            set
            {
                this.className = value;
            }
        }
    }
}
