using System;
using System.Runtime.CompilerServices;

namespace Tic_tac_toe
{
    public class Board
    {
        public char[] cell =
        {
            '1', '2', '3', '4', '5', '6', '7','8','9'
        };

        public Board()
        {
            
        }
        public void Draw()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|         |         |         |");
            Console.WriteLine($"|    {cell[0]}    |    {cell[1]}    |    {cell[2]}    |");
            Console.WriteLine("|         |         |         |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|         |         |         |");
            Console.WriteLine($"|    {cell[3]}    |    {cell[4]}    |    {cell[5]}    |");
            Console.WriteLine("|         |         |         |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|         |         |         |");
            Console.WriteLine($"|    {cell[6]}    |    {cell[7]}    |    {cell[8]}    |");
            Console.WriteLine("|         |         |         |");
            Console.WriteLine("-------------------------------");
        }

        public char CheckForWin()
        {
            if (CheckColumns('X') || CheckRows('X') || CheckDiagonally('X')) return 'X';
            if (CheckColumns('O') || CheckRows('O') || CheckDiagonally('O')) return 'O';
            return ' ';
        }

        private bool CheckDiagonally(char playa)
        {
            if (cell[0] == playa && cell[4] == playa && cell[8] == playa) return true;
            if (cell[2] == playa && cell[4] == playa && cell[6] == playa) return true;
            return false;
        }

        private bool CheckRows(char playa)
        {
            if (cell[0] == playa && cell[1] == playa && cell[2] == playa) return true;
            if (cell[3] == playa && cell[4] == playa && cell[5] == playa) return true;
            if (cell[6] == playa && cell[7] == playa && cell[8] == playa) return true;
            return false;
        }

        private bool CheckColumns(char playa)
        {
            if (cell[0] == playa && cell[3] == playa && cell[6] == playa) return true;
            if (cell[1] == playa && cell[4] == playa && cell[7] == playa) return true;
            if (cell[2] == playa && cell[5] == playa && cell[8] == playa) return true;
            return false;
        }
    }
}
