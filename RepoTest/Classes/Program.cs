using System;
using System.Threading.Channels;

namespace RepoTest.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            do
            {
                Console.Write("\nOptions:" +
                    "\n\t1. Movie" +
                    "\n\t2. Show" +
                    "\n\t3. Video" +
                    "\n\tEnter x to exit application" +
                    "\nWhat would you like to display: ");
                ans = Console.ReadLine();

                switch (ans)
                {
                    case "1": //Movie
                        Media media = new Movie();
                        //((Movie)media).Read();
                        ((Movie)media).Display();
                        break;
                    case "2": //Show
                        media = new Show();
                        //((Show)media).Read();
                        ((Show)media).Display();
                        break;
                    case "3": //Video
                        media = new Video();
                        //((Video)media).Read();
                        ((Video)media).Display();
                        break;
                }
            }
            while (ans != "x");
            Console.WriteLine("Bye");
        }

        /*

        public static void FileInfo()
        {

            Media m1 = new Movie();
            ((Movie)m1).Title = "";
            ((Movie)m1).Genres = "";

            Media m2 = new Show();
            ((Show)m2).Title = "";
            ((Show)m2).Season = 0;
            ((Show)m2).Episode = 0;
            ((Show)m2).Writers = "";

            Media m3 = new Video();
            ((Video)m3).Title = "";
            ((Video)m3).Format = "";
            ((Video)m3).Length = 0;
            ((Video)m3).Regions = "";

        }

        */
    }
}