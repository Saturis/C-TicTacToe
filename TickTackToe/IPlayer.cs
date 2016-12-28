namespace TickTackToe
{
    /// <summary>
    /// defines player methods
    /// </summary>
    public interface IPlayer
    {
        string Piece { get; set; }
        /// <summary>
        /// returns the character that represents the player
        /// </summary>
        /// <returns></returns>
        string GetPiece();
        /// <summary>
        /// gets column number for next move
        /// </summary>
        /// <returns>column number</returns>
        int MoveColumn();
        /// <summary>
        /// get row number for next move
        /// </summary>
        /// <returns>row number</returns>
        int MoveRow();
    }
}
