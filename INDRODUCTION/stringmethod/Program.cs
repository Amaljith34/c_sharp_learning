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

            //replace
            string newString = orginal.Replace("WORLD", "C#");
            Console.WriteLine(newString);

            //substring
            string hello = orginal.Substring(0,9);
            Console.WriteLine(hello);

            //contains
            bool contanhello=orginal.Contains("l ");
            Console.WriteLine(contanhello);


            //indexof
            int index = orginal.IndexOf("RLD");
            Console.WriteLine(index);

            //TRIM
            string trimmed = orginal.Trim();
            Console.WriteLine(trimmed);



        }
    }
}
