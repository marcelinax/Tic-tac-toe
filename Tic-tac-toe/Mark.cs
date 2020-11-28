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

        private readonly char charRepresentation;
    }
}