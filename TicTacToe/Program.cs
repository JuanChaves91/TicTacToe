namespace TicTacToe
{
    class Program
    {
        static int choice;
        static char mark;

        public static void Main(string[] args)
        {
            Board board = new Board();

            Console.WriteLine("TIC-TAC-TOE");
            Console.WriteLine("Player 1: X | Player 2: O\n");

            if(board.GetTurn() % 2 != 0)
            {
                Console.WriteLine("Player 1 turn\n");
                mark = 'X';
            }
            else
            {
                Console.WriteLine("Player 2 turn\n");
                mark = 'O';
            }

            board.Show();
            Console.WriteLine("\n");
            Console.WriteLine("Your choice?: ");
            choice = int.Parse(Console.ReadLine());
            board.SetChoice(choice, mark);

            board.Show();
        }
    }
}