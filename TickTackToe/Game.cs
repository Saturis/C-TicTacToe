using System;
using System.Collections.Generic;

namespace TickTackToe
{
    /// <summary>
    /// class containing game rules and flow control
    /// </summary>
    class Game
    {
        private Board Board;
        List<IPlayer> Players = new List<IPlayer>();
        private bool turn;
        private IPlayer ActivePlayer;
        /// <summary>
        /// contructor for the game class
        /// </summary>
        public Game(IPlayer one, IPlayer two)
        {
            Board = new Board();
            //Human = new Human();
            //Comp = new Computer();
            Players.Add(one);
            Players[0].Piece = "x";
            Players.Add(two);
            Players[1].Piece = "o";
            turn = true;
        }
        /// <summary>
        /// main game loop
        /// </summary>
        public void PlayGame()
        {
            int column, row;
            do
            {
                if (turn) ActivePlayer = Players[0];
                else ActivePlayer = Players[1];
                do
                {
                    turn = !turn;
                    row = ActivePlayer.MoveRow();
                    column = ActivePlayer.MoveColumn();
                }
                while (!Board.ApplyMove(row, column, ActivePlayer));
            }
            while (!Board.CheckWinner(ActivePlayer) && !Board.CheckGameOver());
            Console.WriteLine("Press any key to end.");
            Console.ReadLine();
        }
    }
}
