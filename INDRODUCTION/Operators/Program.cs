namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////operatores/////

            int number1 = 10;
            int number2 = 20;

            //arithamatic operators
            Console.WriteLine(number1+number2);
            Console.WriteLine(number2-number1);
            Console.WriteLine(number1 * number2);
            Console.WriteLine(number2/number1);

            //asignment operators
            Console.WriteLine(number1==number2);
            Console.WriteLine(number1 != number2);
            Console.WriteLine(number1 > number2);
            Console.WriteLine(number1 < number2);


            //condition operator
            if (number1 == number2)
            {
                Console.WriteLine("condition 1 is true");
            }
            else
            {
                Console.WriteLine("condition 2 is true");
            }
                      //&&
            if (number1 != number2 && number1 < number2)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            //ternory operator
            string ternoryoperator = number2 > number1 ? "2nd number is large" : "1st number is large";
            Console.WriteLine(ternoryoperator);
            
            



        }
    }
}
