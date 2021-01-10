using System;
using HB.MarsRoverProblem.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HB.MarsRoverProblem.Model.Tests
{
    [TestClass()]
    public class RoverTests
    {
        [TestMethod]
        public void FirstRoverCheckOutput()
        {
            var firstPlateau = new Plateau(new Position(5, 5));
            var firstRover = new Rover(firstPlateau, new Position(1, 2), Direction.Directions.N);
            firstRover.Do(@"LMLMLMLMM");
            Assert.AreEqual(firstRover.ToString(), "1 3 N");
        }

        [TestMethod]
        public void SecondRoverCheckOutput()
        {
            var secondPlateau = new Plateau(new Position(5, 5));
            var secondRover = new Rover(secondPlateau, new Position(3, 3), Direction.Directions.E);
            secondRover.Do(@"MMRMMRMRRM");
            Assert.AreEqual(secondRover.ToString(), "5 1 E");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IncorrectInput()
        {
            var firstPlateau = new Plateau(new Position(5, 5));
            var firstRover = new Rover(firstPlateau, new Position(1, 2), Direction.Directions.N);
            firstRover.Do("HEPSIBURADA");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IncorrectInput2()
        {
            var firstPlateau = new Plateau(new Position(2, 2));
            var firstRover = new Rover(firstPlateau, new Position(1, 2), Direction.Directions.N);
            firstRover.Do("LMLMLMLMM");
        }
    }
}