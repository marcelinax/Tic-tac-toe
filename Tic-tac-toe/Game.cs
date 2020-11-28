using System;

namespace Tic_tac_toe
{
    public class Game
    {
        Board board = new Board();
        public Game(Player player1, Player player2)
        {
           if (player1.Mark.Equals(player2.Mark))
            {
                throw new ArgumentException("nunu");
            }

        }

        private Player activePlayer;
        private Player otherPlayer;

        public void ChangePlayer()
        {
            Player tempPlayer = activePlayer;
            activePlayer = otherPlayer;
            otherPlayer = tempPlayer;
        }

        private Player CheckPlayerByMark(char sign)
        {
            if (activePlayer.ToString().Equals(sign.ToString()))
            {
                return activePlayer;
            }

            return otherPlayer;
        }
        public void CheckWinner()
        {

        }
    }
} 