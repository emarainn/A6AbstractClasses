namespace RepoTest.Classes
{
    public class Movie : Media
    {
        public string Genres { get; set; }

        public override void Display()
        {
            string moviesfile = $"{Environment.CurrentDirectory}/Files/movies.csv";
            Console.WriteLine("\nMOVIES:");
            Read(moviesfile);
        }
        public void Read(string moviesfile)
        {
            if (File.Exists(moviesfile))
            {
                StreamReader sr = new StreamReader(moviesfile);

                while (sr.EndOfStream != true)
                {
                    Console.WriteLine(sr.ReadLine());
                }

            }
        }

    }

}