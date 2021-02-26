using System;
using System.Linq;
using Xunit;

namespace TransportTycoon.Tests
{
    public class SolutionTests
    {
        [Theory]
        [InlineData("A", 5)]
        [InlineData("AB", 5)]
        [InlineData("BB", 5)]
        [InlineData("ABB", 7)]
        //[InlineData("AABABBAB", )]
        //[InlineData("AAAABBBB", )]
        //[InlineData("BBBBAAAA", )]
        //[InlineData("ABBBABAAABBB", )]
        public void ShouldDeliver(string destinations, int durationTimeInHours)
        {
            // Arrange
            var solution = new Solution(destinations.Select(x => x.ToString()));

            // Act
            solution.Deliver();

            // Assert
            Assert.Equal(TimeSpan.FromHours(durationTimeInHours), solution.CurrentTime);
        }
    }
}
