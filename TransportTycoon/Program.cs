using System.Linq;

namespace TransportTycoon
{
    class Program
    {
        static void Main(string[] args)
        {
            var destinations = args[0];

            var solution = new Solution(destinations.Select(x => x.ToString()));
        }
    }
}
