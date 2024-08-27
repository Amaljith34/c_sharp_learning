namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintPersonalizedMessage("jone", 22);
        }
        static void PrintPersonalizedMessage(string name,int age)
        {
            Console.WriteLine($"Hello, {name} you are {age} years old");
        }
    }
}
