namespace _04.ReverseArrayOffStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputArrays = Console.ReadLine();

            string[] arrays = inputArrays.Split(' ');

            //for (int i = 0; i < arrays.Length; i++)
            //{
            //    string[] reversedArrays = 
            //}

            Array.Reverse(arrays);
            Console.WriteLine(string.Join(' ', arrays));
        }
    }
}
