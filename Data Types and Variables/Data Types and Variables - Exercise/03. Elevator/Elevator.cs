namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peoplesCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;

            courses = peoplesCount / capacity;

            if (peoplesCount % capacity != 0)
            {
                peoplesCount %= capacity;

                if ( peoplesCount <= capacity)
                {
                    courses++;
                }
                else
                {
                    courses %= peoplesCount;
                }
            }
            Console.WriteLine(courses);
        }
    }
}
