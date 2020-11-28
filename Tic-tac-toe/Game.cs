using System;

namespace Tic_tac_toe
{
    public class Game
    {
        Board board = new Board();
        public Game(Player player1, Player player2)
        {
            activePlayer = player1;
            otherPlayer = player2;
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
            if (activePlayer.mark.ToString().Equals(sign.ToString()))
            {
                return activePlayer;
            }

            return otherPlayer;
        }
        public void CheckWinner()
        {
            switch (board.CheckForWin())
            {
                case 'X' :
                    Console.WriteLine($"{CheckPlayerByMark('X')} is the winner!"); 
                    break;
                case 'O':
                    Console.WriteLine($"{CheckPlayerByMark('O')} is the winner!");
                    break;
                case ' ':
                    Console.WriteLine("Draw!");
                    break;
            }
        }
    }
} 