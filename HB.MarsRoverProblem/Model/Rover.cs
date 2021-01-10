using System;
using HB.MarsRoverProblem.Helper;
using HB.MarsRoverProblem.Interface;

namespace HB.MarsRoverProblem.Model
{
    public class Rover : IRover
    {
        public IPosition Position { get; set; }
        public Direction.Directions Directions { get; set; }

        public Plateau Plateau { get; set; }


        public Rover(Plateau plateau, IPosition roverPosition, Direction.Directions roverDirection)
        {
            Position = roverPosition;
            Directions = roverDirection;
            Plateau = plateau;
        }

        #region Main Process

        public void Do(string inputs)
        {
            foreach (var input in inputs)
            {
                switch (input)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        Move();
                        break;
                    default:
                        throw new ArgumentException();
                }

                if (Position.X < 0 || Position.X > Plateau.X || Position.Y < 0 || Position.Y > Plateau.Y)
                {
                    throw new Exception($"Exceed the Plateau size : -- Plateau Info --\n { Plateau.ToString()}");
                }
            }
        }

        #endregion

        #region Rotate And Move Process

        private void TurnLeft() => Directions = (Directions - 1) < Direction.Directions.N ? Direction.Directions.W : Directions - 1;

        private void TurnRight() => Directions = (Directions + 1) > Direction.Directions.W ? Direction.Directions.N : Directions + 1;

        private void Move()
        {
            switch (Directions)
            {
                case Direction.Directions.N:
                    Position.Y++;
                    break;
                case Direction.Directions.E:
                    Position.X++;
                    break;
                case Direction.Directions.S:
                    Position.Y--;
                    break;
                case Direction.Directions.W:
                    Position.X--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        public override string ToString() => $"{Position.X} {Position.Y} {Directions}";
    }
}