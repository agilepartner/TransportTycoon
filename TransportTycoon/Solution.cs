using System;
using System.Collections.Generic;
using System.Text;

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
            CurrentTime = new TimeSpan(5, 0, 0);
        }
    }
}
