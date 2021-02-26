using System;
using System.Collections.Generic;

namespace TransportTycoon
{
    public class Solution
    {
        public Solution(IEnumerable<string> destinations)
        {

        }

        public TimeSpan CurrentTime { get; private set; }

        public void Deliver()
        {
            CurrentTime = TimeSpan.FromHours(5);
        }
    }
}
