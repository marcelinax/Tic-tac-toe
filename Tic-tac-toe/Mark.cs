using System;

namespace Tic_tac_toe
{
    public class Mark
    {
        public Mark(char mark)
        {
            if(mark == 'X' || mark == 'O')
                charRepresentation = mark;
            else throw new ArgumentException("Incorrect sign!");
        }

        public override string ToString()
        {
            return charRepresentation.ToString();
        }

        private readonly char charRepresentation;
    }
}