using System;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            var boardzik = new Board();
            var playerek = new Player(new Mark('X'));
            
            boardzik.Draw();
            playerek.Move(boardzik);
            
            
        }
    }
}