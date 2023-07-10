namespace _05.Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string reversedUsername = new string(stringArray);
            //Console.Write($"Actual String is : {username} \n");
            //Console.Write($"Reversed String is : {reversedName} ");

            for (int i = 1; i <= 4; i++)
            {
                
                if (password == reversedUsername)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (i == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break; ;
                }
                
                if (password != reversedUsername)
                {
                   Console.WriteLine("Incorrect password. Try again.");
                }
                
                //char[] stringArray = username.ToCharArray();
                //Array.Reverse(stringArray);
                //string reversedName = new string(stringArray);
                //Console.Write($"Actual String is : {username} \n");
                //Console.Write($"Reversed String is : {reversedName} ");
                password = Console.ReadLine();
            }
            


        }
    }
}
