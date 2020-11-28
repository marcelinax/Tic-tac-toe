using System;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = new Board();
            b.Draw();
            var p = new Player(new Mark('X'));
            p.IndtroduceYourself();
            p.Move(b);
        }
    }
}