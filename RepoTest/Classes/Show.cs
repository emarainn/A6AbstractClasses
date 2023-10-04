using RepoTest.Classes;

namespace MyNamespace
{
    public class Show : Media
    {

        public int Season { get; set; }
        public int Episode { get; set; }
        public string Writers { get; set; }

        public override string Display()
        {
            return null;
        }
    }

}