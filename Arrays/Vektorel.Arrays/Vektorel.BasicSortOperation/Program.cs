namespace Vektorel.BasicSortOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("v1");
            Version1();
            Console.WriteLine("v2");
            Version2();
        }

        static void Version1()
        {
            //Ödev
            var unOrderedNumbers = new int[]
            {
                12, 24, 1, 6, 98, 23, 6, 13, 25, 36, 8
            };

            var index = 0;
            while (true)
            {
                var swapped = false;
                var selected = unOrderedNumbers[index];
                var next = unOrderedNumbers[index + 1];
                if (selected > next)
                {
                    var backup = next; // yedekleme alanı (boncuk tutan parmak)
                    unOrderedNumbers[index + 1] = selected;
                    unOrderedNumbers[index] = backup;
                    swapped = true;
                }

                if (swapped)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }

                if ((index + 1) == unOrderedNumbers.Length)
                {
                    break;
                }
            }

            foreach (var number in unOrderedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Bitti");

            // 1, 6, 6, 8, 12, 13, 24, 25, 36, 98
        }

        static void Version2()
        {
            var unOrderedNumbers = new int[]
            {
                12, 24, 1, 6, 98, 23, 6, 13, 25, 36, 8
            };

            var index = 0;
            while (index < unOrderedNumbers.Length - 1)
            {
                if (unOrderedNumbers[index] > unOrderedNumbers[index + 1])
                {
                    var temp = unOrderedNumbers[index];
                    unOrderedNumbers[index] = unOrderedNumbers[index + 1];
                    unOrderedNumbers[index + 1] = temp;
                    index = 0;
                    //Level 99
                    //(unOrderedNumbers[index], unOrderedNumbers[index + 1]) = (unOrderedNumbers[index + 1], unOrderedNumbers[index]);
                }
                else 
                { 
                    index++; 
                }
            }

            foreach (var number in unOrderedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Bitti");
        }
    }
}
