using System;

namespace TickTackToe
{
    class Human : IPlayer
    {
        public string Piece { get; set; }
        public string GetPiece()
        {
            return Piece;
        }

        public int MoveColumn()
        {
            Console.WriteLine("Choose a column (0 - 2)");
            int column = Convert.ToInt16(Console.ReadLine());
            if(column < 0 || column > 2)
            {
                Console.WriteLine("That is an invalid choice.\n");
                column = MoveColumn();
            }
            return column;
        }

        public int MoveRow()
        {
            Console.WriteLine("Choose a row (0 - 2)");
           int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (row < 0 || row > 2)
            {
                Console.WriteLine("That is an invalid choice.\n");
                row = MoveRow();
            }
            return row;
        }
    }
}
