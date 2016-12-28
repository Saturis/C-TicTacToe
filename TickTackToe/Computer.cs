using System;

namespace TickTackToe
{
    class Computer : IPlayer
    {
        Random rnd;

        public Computer()
        {
            rnd = new Random();
        }

        public string Piece { get; set; }
        

        public string GetPiece()
        {
            return Piece;
        }

        public int MoveColumn()
        {
            int c = rnd.Next(0, 3);
            return c;
        }

        public int MoveRow()
        {
            int r = rnd.Next(0, 3);
            return r;
        }
    }
}
