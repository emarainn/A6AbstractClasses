using System.Threading.Channels;

namespace RepoTest.Classes
{
    public class Video : Media
    {
        public string Format { get; set; }
        public int Length { get; set; }
        public string Regions { get; set; }

        public override void Display()
        {
            string videosfile = $"{Environment.CurrentDirectory}/Files/videos.csv";
            Console.WriteLine("\nVIDEOS:");
            Read(videosfile);
        }

        public void Read(string videosfile)
        {
            if (File.Exists(videosfile))
            {
                StreamReader sr = new StreamReader(videosfile);

                while (sr.EndOfStream != true)
                {
                    Console.WriteLine(sr.ReadLine());
                }

            }
        }
    }

}