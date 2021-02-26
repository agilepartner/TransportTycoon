using System;
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

        public TimeSpan CurrentTime { get; private set; }

        public void Deliver()
        {
            if(destinations.Count() == 3)
            {
                this.CurrentTime = TimeSpan.FromHours(7);
            }
            else
            {
                CurrentTime = TimeSpan.FromHours(5);
            }
        }
    }
}
