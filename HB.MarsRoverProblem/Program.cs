using System;
using HB.MarsRoverProblem.Helper;
using HB.MarsRoverProblem.Model;

namespace HB.MarsRoverProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstPlateau = new Plateau(new Position(5, 5));
            var firstRover = new Rover(firstPlateau, new Position(1, 2), Direction.Directions.N);
            firstRover.Do(@"LMLMLMLMM");


            var secondPlateau = new Plateau(new Position(5, 5));
            var secondRover = new Rover(secondPlateau, new Position(3, 3), Direction.Directions.E);
            secondRover.Do(@"MMRMMRMRRM");

            Console.WriteLine("*****Output******");
            Console.WriteLine(firstRover.ToString());
            Console.WriteLine(secondRover.ToString());

            Console.ReadLine();
        }
    }
}