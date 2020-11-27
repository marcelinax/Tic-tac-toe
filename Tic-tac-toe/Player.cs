using System;
using System.Linq;
using Microsoft.VisualBasic.FileIO;

namespace Tic_tac_toe
{
    public class Player
    {
        public Player(Mark m)
        {
            mark = m;
        }
        
        private Mark mark;
        private string nickName;

        public string NickName
        {
            get { return nickName; }
            set
            {
                if (value.ElementAt(0).Equals(value.ElementAt(0).ToString().ToUpper()))
                {
                    nickName = value;
                }
                else throw new ArgumentException("Name must start with a capital letter!");
            }
        }
        public void Move(Board board)
        {
            
        }

        public void IndtroduceYourself()
        {
            Console.WriteLine("What's your name?");
            nickName = Console.ReadLine();
            Console.WriteLine($"Hello {nickName}! Nice to meet you!");
        }
    }
}