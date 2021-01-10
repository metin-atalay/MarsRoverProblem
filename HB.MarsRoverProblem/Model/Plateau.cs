using HB.MarsRoverProblem.Interface;

namespace HB.MarsRoverProblem.Model
{
    public class Plateau : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Plateau(IPosition position)
        {
            X = position.X;
            Y = position.Y;
        }

        public override string ToString() => $"The Plateau Info MaxX: {X} MaxY: {Y} " + base.ToString();
    }
}