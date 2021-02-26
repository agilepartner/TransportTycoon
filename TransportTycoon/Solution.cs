using System.Collections.Generic;
using System.Linq;
using System;

namespace TransportTycoon
{
    public class Vehicle
    {
        public int TotalDuration { get; set; }

        public Vehicle(int totalDuration)
        {
            this.TotalDuration = totalDuration;
        }
    }

    public class Solution
    {
        Dictionary<string, int> Routes = new Dictionary<string, int>()
        {
            {"B", 10}
        };

        Dictionary<string, int> Trucks = new Dictionary<string, int>()
        {
            {"1", 0},
            {"2", 0}
        };

        private readonly List<string> destinations;

        public Solution(IEnumerable<string> destinations)
        {
            this.destinations = destinations.ToList();
        }

        public int CurrentTime { get; private set; }

        public void Deliver()
        {
            int t = 0;
            var truckA = new Vehicle(0);
            var truckB = new Vehicle(0);
            while (true)
            {
                if (truckA.TotalDuration == 0)
                {
                    var newDestination = this.destinations[0];
                    this.destinations.RemoveAt(0);
                    truckA.TotalDuration = Routes[newDestination];
                }

                if (truckB.TotalDuration == 0)
                {
                    var newDestination = this.destinations[0];
                    this.destinations.RemoveAt(0);
                    truckB.TotalDuration = Routes[newDestination];
                }

                truckA.TotalDuration--;
                truckB.TotalDuration--;

                if (destinations.Count() <= 0)
                {
                    break;
                }
                t++;
            }
            CurrentTime = t + 5;
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
