namespace Sample
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string Name = Console.ReadLine();

            Console.WriteLine("please enter your age : ");
            string Age = Console.ReadLine();

            //string concatenation
            Console.WriteLine("hello" + Name + "age is " + Age);

            //composite formatting
            Console.WriteLine("hello {1},{0}", Name, Age);

            //string interpolation
            Console.WriteLine($"hello {Name} age is   {Age}");





           ///////////datatypes//////////////////////

            //char
            char c = 'A';
            Console.WriteLine(c);
            char d = (char)(c + 1);
            Console.WriteLine(d);

            //string
            string name = "AMALJITH";
            Console.WriteLine(name);
            Console.WriteLine(name[2]);
            Console.WriteLine(name[0]+"hi");

            //int
            int length = name.Length;
            Console.WriteLine(length);
            
            //float
            float area = float.Pi * 10;
            Console.WriteLine(area);


            int i = 1200;
            i = 200;
            Console.WriteLine(i);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

        


            //escape sequence
            string test="hello\"world\"";
            Console.WriteLine(test);
            //verbatim literals
            string s = @"HELLO\world";
            Console.WriteLine(s);


            //conversion
            Console.WriteLine(test.ToUpper());
            Console.WriteLine(s.ToLower());

            
            




            Console.ReadKey();
        }
    }
}
