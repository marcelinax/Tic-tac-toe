using System;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            var board = new Board();
            var player1 = new Player(new Mark('X'));
            var player2 = new Player(new Mark('O'));

            
            player1.IndtroduceYourself();
            player1.Move(board);
            player2.IndtroduceYourself();
            player2.Move(board);
        }
    }
}