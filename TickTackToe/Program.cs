namespace TickTackToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new Computer(), new Computer());
            game.PlayGame();
        }
    }
}