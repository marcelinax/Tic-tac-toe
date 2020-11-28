using System;

namespace Tic_tac_toe
{
    public class Mark
    {
        private readonly char _charRepresentation;
        public Mark(char mark)
        {
            if(mark == 'X' || mark == 'O')
                _charRepresentation = mark;
            else throw new ArgumentException("Incorrect sign!");
        }

        public override string ToString()
        {
            return _charRepresentation.ToString();
        }

    }
}