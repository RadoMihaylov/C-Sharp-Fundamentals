namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());     

            for (int i = 0; i < rotations; i++)
            {
                int firstElemnt = ints[0];
                for (int k = 0; k < ints.Length -1; k++)
                {
                    ints[k] = ints[k + 1];

                }
                ints[ints.Length - 1] = firstElemnt;
            }

            Console.WriteLine(string.Join(" ", ints));
        }
    }
}
