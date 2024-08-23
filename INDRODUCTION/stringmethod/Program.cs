namespace stringmethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tolower
            string orginal = "hello WORLD";
            string lowercase=orginal.ToLower();
            Console.WriteLine(lowercase);

            //TOUPPER
            string uppercase=orginal.ToUpper();
            Console.WriteLine(uppercase);

            //split
            string originalfruts = "apple,banana,orange";
            string[] fruits = originalfruts.Split(',');
            foreach(var i in fruits) 
            Console.WriteLine(i);

            //length
            int length=orginal.Length;
            Console.WriteLine(length);

            //substring
            string newString = orginal.Replace("WORLD", "C#");
            Console.WriteLine(newString);
        }
    }
}
