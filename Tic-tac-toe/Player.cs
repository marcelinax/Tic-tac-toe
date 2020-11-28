using System;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace Tic_tac_toe
{
    public class Player
    {
        public Player(Mark playerMark)
        {
            mark = playerMark;
        }
        
        public Mark mark;
        private string nickName;
      
        public string NickName
        {
            get => nickName;
            set
            {
                //if (value.ElementAt(0).Equals(value.ElementAt(0).ToString().ToUpper()))
                if (value.ElementAt(0).Equals(char.ToUpper(value.ElementAt(0))))
                {
                    nickName = value;
                }
                else throw new ArgumentException("Name must start with a capital letter!");
            }
        }

        public override string ToString()
        {
            return NickName;
        }

        public void Move(Board board)
        {
            Console.WriteLine("Enter the field: (1-9)");
            short _position = Convert.ToInt16(Console.ReadLine());
            
            board.cell[(_position - 1)] = Convert.ToChar(mark.ToString());
            board.Draw();
        }

        public void IndtroduceYourself()
        {
            Console.WriteLine("What's your name?");
            NickName = Console.ReadLine();
            Console.WriteLine($"Hello {NickName}! Nice to meet you!");
        }
    }
}