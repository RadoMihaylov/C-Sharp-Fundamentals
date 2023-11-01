using System.ComponentModel;
using System.Security.Cryptography;

namespace _03._Songs
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("_").ToArray();
                string typeList = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song (typeList, name, time);
                songs.Add( song );
            }
            string lastCommand = Console.ReadLine();

            if (lastCommand == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == lastCommand)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }


    }
}
