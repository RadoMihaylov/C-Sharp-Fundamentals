namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTheArea(width, height);
            Console.WriteLine(area);

        }

        static double GetTheArea(double width, double height)
        {
            return width* height;
        }
    }
}
