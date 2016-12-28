using System;

namespace TickTackToe
{
    class Board
    {
        private string[][] GameBoard;
        private int count = 0;

        public Board()
        {
            GameBoard = new string[3][];
            for (int i = 0; i < GameBoard.Length; i++)
            {
                GameBoard[i] = new string[3];
            }
            for (int i = 0; i < GameBoard.Length; i++)
            {
                for (int j = 0; j < GameBoard[i].Length; j++)
                {
                    GameBoard[i][j] = "-";
                }
            }
            UpdateBoard();
        }
        public bool ApplyMove(int c, int r, IPlayer player)
        {

            if (GameBoard[c][r] == "-")
            {
                GameBoard[c][r] = player.GetPiece();
                UpdateBoard();
                count++;
                return true;
            }
            return false;
        }

        public bool CheckGameOver()
        {
            if (count >= 9)
            {
                Console.WriteLine("The game is a tie.");
                return true;
            }
            return false;
        }
        /// <summary>
        /// checks to see if a player has won the game
        /// </summary>
        /// <param name="player">player that is being checked</param>
        /// <returns>if the player has won</returns>
        public bool CheckWinner(IPlayer player)
        {
            bool winner = false;
            for (int i = 0; i < GameBoard.Length; i++)
            {
                if (GameBoard[i][0].CompareTo(player.GetPiece()) == 0 && GameBoard[i][1].CompareTo(player.GetPiece()) == 0 && GameBoard[i][2].CompareTo(player.GetPiece()) == 0)
                {
                    winner = true;
                    Console.WriteLine("{0} has won the game.", player.GetPiece());
                    break;
                }
            }
            for (int i = 0; i < GameBoard[0].Length; i++)
            {
                if (GameBoard[0][i].CompareTo(player.GetPiece()) == 0 && GameBoard[1][i].CompareTo(player.GetPiece()) == 0 && GameBoard[2][i].CompareTo(player.GetPiece()) == 0)
                {
                    winner = true;
                    Console.WriteLine("{0} has won the game.", player.GetPiece());
                    break;
                }
            }
            if (GameBoard[0][0].CompareTo(player.GetPiece()) == 0 && GameBoard[1][1].CompareTo(player.GetPiece()) == 0 && GameBoard[2][2].CompareTo(player.GetPiece()) == 0)
            {
                winner = true;
                Console.WriteLine("{0} has won the game.", player.GetPiece());
            }
            if (GameBoard[0][2].CompareTo(player.GetPiece()) == 0 && GameBoard[1][1].CompareTo(player.GetPiece()) == 0 && GameBoard[2][0].CompareTo(player.GetPiece()) == 0)
            {
                winner = true;
                Console.WriteLine("{0} has won the game.", player.GetPiece());
            }
            return winner;
        }
        private void UpdateBoard()
        { 
            for (int i = 0; i < GameBoard.Length; i++)
            {
                for (int j = 0; j < GameBoard[0].Length; j++)
                {
                    Console.Write(GameBoard[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
