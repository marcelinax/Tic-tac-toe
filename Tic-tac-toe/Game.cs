using System;

namespace Tic_tac_toe
{
    public class Game
    {
        Board board = new Board();
        private Player activePlayer;
        private Player otherPlayer;
        private bool gameOnGoing = true;
        public Game(Player playerOne, Player playerTwo)
        {
           if (player1.Mark.Equals(player2.Mark))
            {
                throw new ArgumentException("nunu");
            }

            activePlayer = playerOne;
            otherPlayer = playerTwo;
            Start();
        }

        private void Start()
        {
            activePlayer.IndtroduceYourself();
            otherPlayer.IndtroduceYourself();
            int moves = 1;
            do
            {
                activePlayer.Move(board);
                moves++;
                if (moves < 9)
                {
                    CheckWinner();
                    ChangePlayer();
                }
                else
                {
                    Console.WriteLine("Draw!");
                    gameOnGoing = false;
                }

            } while (gameOnGoing);
        }

        public void ChangePlayer()
        {
            var tempPlayer = activePlayer;
            activePlayer = otherPlayer;
            otherPlayer = tempPlayer;
        }

        private Player CheckPlayerByMark(char sign)
        {
            return activePlayer.mark.ToString().Equals(sign.ToString()) ? activePlayer : otherPlayer;
        }
        public void CheckWinner()
        {
            switch (board.CheckForWin())
            {
                case 'X' :
                    Console.WriteLine($"{CheckPlayerByMark('X')} is the winner!");
                    gameOnGoing = false;
                    break;
                case 'O':
                    Console.WriteLine($"{CheckPlayerByMark('O')} is the winner!");
                    gameOnGoing = false;
                    break;
                case ' ':
                    gameOnGoing = true;
                    break;
                default:
                    gameOnGoing = true;
                    break;
            }
        }
    }
} 