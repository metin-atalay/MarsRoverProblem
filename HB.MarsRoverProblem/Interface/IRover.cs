using HB.MarsRoverProblem.Helper;

namespace HB.MarsRoverProblem.Interface
{
    public interface IRover
    {
        IPosition Position { get; set; }
        Direction.Directions Directions { get; set; }
        void Do(string inputs);
    }
}