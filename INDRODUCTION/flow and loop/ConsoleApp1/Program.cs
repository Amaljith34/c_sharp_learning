using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if
            int age = 21;
            if (age > 18)
            {
                Console.WriteLine("age above 18");
            }
            else
            {
                Console.WriteLine("sorry your age is below 18");
            }

            Console.WriteLine("enter your age");
            string input = Console.ReadLine();
            int ages;

            if (int.TryParse(input, out ages))
            {
                if (ages >= 18)
                {
                    Console.WriteLine("age above 18");
                }
                else
                {
                    Console.WriteLine("sorry your age is below 18");
                }
            }
            else
            {
                Console.WriteLine("invalid input ,enter valid number");
            }



            //switch
            string input1 = Console.ReadLine();
            int number;
            if (int.TryParse(input1, out number))
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You entered one.");
                        break;
                    case 2:
                        Console.WriteLine("You entered two.");
                        break;
                    case 3:
                        Console.WriteLine("You entered three.");
                        break;
                    case 4:
                        Console.WriteLine("You entered four.");
                        break;
                    case 5:
                        Console.WriteLine("You entered five.");
                        break;
                    default:
                        Console.WriteLine("The number is not between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a valid number.");
            }





            //////loop//////////////
            ///

            //for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("itration: " + i);
            }

            //while
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine("count: " + count);
                count++;
            }


            //dowhileloop
            int count1 = 0;
            do
            {
                Console.WriteLine("count : " + count1);
                count1++;

            } while (count1 < 10);


            //foreach
            int[] nums = { 1, 56, 8, 7, 2, 3 };
            int items = 0;
            foreach (int item in nums)
            {
                Console.WriteLine( items=items+item);
            }

            //paralelforeach
            List<int> numberss = new List<int> { 11,12,54,456,6,8,3,4,9,4 };

            Parallel.ForEach(numberss, number =>
            {
                Console.WriteLine($"Processing number {number} on thread {Task.CurrentId}");
               
            });

            Console.WriteLine("All numbers processed.");

            Console.ReadKey();

        }
    }
}
