using System;

namespace Tic_tac_toe
{

    public class GameBuilder
    {
        private IPlayer player1;
        private IPlayer player2;

        public void SetUpPlayer1()
        {
            player1 = BuildPlayer('X');

        }
        public void SetUpPlayer2()
        {
            player2 = BuildPlayer('O');
        }

        private IPlayer BuildPlayer(char c)
        {

            Console.WriteLine($"Player {c}, what's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}! Nice to meet you!");

            var newPlayer = new Player(new Mark(c), name);
            SafePlayer safePlayer = new SafePlayer(newPlayer);

            return safePlayer;
        }

        public Game Build()
        {

            return new Game(player1, player2);
        }
    }

    public class Game
    {
        Board board = new Board();
        private IPlayer activePlayer;
        private IPlayer otherPlayer;
        private bool gameOnGoing = true;
        public Game(IPlayer playerOne, IPlayer playerTwo)
        {
            if (playerOne.Mark.Equals(playerTwo.Mark))
            {
                throw new ArgumentException("nunu");
            }

            activePlayer = playerOne;
            otherPlayer = playerTwo;
            Start();
        }

        private void Start()
        {

            int moves = 1;
            board.Draw();
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

        private IPlayer CheckPlayerByMark(char sign)
        {
            return activePlayer.Mark.ToString().Equals(sign.ToString()) ? activePlayer : otherPlayer;
        }
        public void CheckWinner()
        {
            switch (board.CheckForWin())
            {
                case 'X':
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