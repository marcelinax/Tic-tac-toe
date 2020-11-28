using System;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            var gameBuilder = new GameBuilder();
            gameBuilder.SetUpPlayer1();
            gameBuilder.SetUpPlayer2();
            gameBuilder.Build();

        }
    }
}