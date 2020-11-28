using System;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace Tic_tac_toe
{
    public class Player : IPlayer
    {

        public Player(Mark playerMark, string name)
        {
            mark = playerMark;
            nickName = name;
        }

        public Mark Mark { get { return mark; } }

        private Mark mark;
        private string nickName;

        public string NickName
        {
            get => nickName;
            set
            {
                nickName = value;
            }
        }

        public override string ToString()
        {
            return NickName;
        }

        public void Move(Board board)
        {
            Console.WriteLine("Enter the field: (1-9)");
            var position = Convert.ToInt16(Console.ReadLine());

            if (board.cell[position - 1] != 'X' && board.cell[position - 1] != 'O')
            {
                board.cell[(position - 1)] = Convert.ToChar(mark.ToString());
                Console.Clear();
                board.Draw();
            }
            else throw new ArgumentException("Position already taken!");

        }


    }

    public class SafePlayer : IPlayer
    {
        IPlayer innerPlayer;

        public Mark Mark { get { return innerPlayer.Mark; } }
        public SafePlayer(IPlayer playerArgument)
        {
            innerPlayer = playerArgument;

        }

        public void Move(Board board)
        {
            try
            {
                innerPlayer.Move(board);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Try Again!");
                Move(board);
            }
        }
        public override string ToString()
        {
            return innerPlayer.ToString();
        }
    }
}