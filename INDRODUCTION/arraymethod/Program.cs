namespace arraymethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //index of
            int[] arr = { 2, 8, 6, 7 };
            Array.Sort(arr);
            
            foreach(int i in arr)
            {
                Console.WriteLine(i);

            }
        }
    }
}
