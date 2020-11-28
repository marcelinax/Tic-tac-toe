namespace Tic_tac_toe
{
    public interface IPlayer
    {

        void Move(Board board);

        Mark Mark { get; }
    }
}