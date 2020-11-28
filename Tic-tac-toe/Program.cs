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
            var gra = new Game(new Player(new Mark('X')), new Player(new Mark('O')));
            
        }
    }
}