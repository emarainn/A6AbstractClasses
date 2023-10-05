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
                        ((Movie)media).Display();
                        break;
                    case "2": //Show
                        media = new Show();
                        ((Show)media).Display();
                        break;
                    case "3": //Video
                        media = new Video();
                        ((Video)media).Display();

                        break;
                }
            }
            while (ans != "x");
            Console.WriteLine("Bye");
        }
    }
}