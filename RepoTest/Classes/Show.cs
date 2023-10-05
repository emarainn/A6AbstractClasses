
using System;

namespace RepoTest.Classes
{
    public class Show : Media
    {

        public int Season { get; set; }
        public int Episode { get; set; }
        public string Writers { get; set; }

        public override void Display()
        {
            string showsfile = $"{Environment.CurrentDirectory}/Files/shows.csv";
            Console.WriteLine("\nSHOWS:");
            Read(showsfile);
        }

        public void Read(string showsfile)
        {
            if (File.Exists(showsfile))
            {
                StreamReader sr = new StreamReader(showsfile);

                while (sr.EndOfStream != true)
                {
                    Console.WriteLine(sr.ReadLine());
                }

            }
        }
    }

}
