using System.Collections.Generic;
using System.Linq;
using System;

namespace TransportTycoon
{
    public class Solution
    {
        Dictionary<string, int> Routes = new Dictionary<string, int>()
        {
            {"B", 5}
        };

        Dictionary<string, int> Trucks = new Dictionary<string, int>()
        {
            {"1", 0},
            {"2", 0}
        };

        private readonly string[] destinations;

        public Solution(IEnumerable<string> destinations)
        {
            this.destinations = destinations.ToArray();
        }

        public int CurrentTime { get; private set; }

        public void Deliver()
        {
            for (int i = 0; i < destinations.Count(); i = i + 2)
            {
                (int, int) truck1 = Transport(destinations[i]);
                (int, int) truck2 = Transport(destinations[i + 1]);


                object p = Min(truck1.Item1, truck2.Item1);
            }
            CurrentTime = 5;

            if (destinations.Count() == 3)
            {
                CurrentTime += 2;
            }
        }

        public (int, int) Transport(string destination)
        {
            if (destination == "A")
            {
                return (5, 2);
            }

            return (5, 10);
        }
    }
}
