namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //////conversion//////////

            //var a = Console.ReadLine();
            //var b = Console.ReadLine();
            /////Readline() it is a string
            //Console.WriteLine($"sum of two numbers ={a+b}");



         //implicit  (Automatically convert to  a smaller data type to larger data type without any spacial syntax)
            int num = 10;
            double doublenum = num;
            Console.WriteLine(doublenum);


         //explicit  
            double dnum = 10.7;
            int inum = (int)dnum;
            Console.WriteLine(inum);


         //convert class
            string str = "123";
            int num1=Convert.ToInt32(str);
            Console.WriteLine(num1);

            string doublestr = "12.25";
            double num2 = Convert.ToDouble(doublestr);
            Console.WriteLine(num2);

            int num3 = 123;
            string str3 = Convert.ToString(num3);
            Console.WriteLine(str3);
            Console.WriteLine( str3.GetType());


            //parse method
            string str1 = "123456";
            int num4 = int.Parse(str1);
            Console.WriteLine(num4);


            ///tryparse method
            bool sucess=int.TryParse(str1, out  num4);
            if (sucess)
            {
                Console.WriteLine(num4);

            }
            else
            {
                Console.WriteLine("failed");
            }
             






        }
    }
}
