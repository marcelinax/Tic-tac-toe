using static Tic_tac_toe.Board;

namespace Tic_tac_toe
{
    public class Game
    {
        public Game(Player player1, Player player2)
        {
           
        }

        private Player activePlayer;
        private Player otherPlayer;

        public void ChangePlayer()
        {
            Player tempPlayer = activePlayer;
            activePlayer = otherPlayer;
            otherPlayer = tempPlayer;
        }

        public void CheckWinner()
        {
            Board.CheckForWin();
        }
    }
} 