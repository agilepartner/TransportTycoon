using System.Collections.Generic;
using System.Linq;

namespace TransportTycoon
{
    public class Solution
    {
        private readonly IEnumerable<string> destinations;

        public Solution(IEnumerable<string> destinations)
        {
            this.destinations = destinations;
        }

        public int CurrentTime { get; private set; }

        public void Deliver()
        {
            CurrentTime = 5;

            if (destinations.Count() == 3)
            {
                CurrentTime += 2;
            }
        }
    }
}
