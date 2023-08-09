namespace TicTacToe
{
    class Program
    {
        static int choice;
        static char mark;
        static int flag;

        public static void Main(string[] args)
        {
            Board board = new Board();

            do
            {
                Console.Clear();
                Console.WriteLine("TIC-TAC-TOE");
                Console.WriteLine("Player 1: X | Player 2: O\n");
                board.Show();
                //Console.WriteLine("\n");
                if(board.GetTurn() % 2 != 0)
                {
                    Console.WriteLine("\nPlayer 1 turn");
                    mark = 'X';
                }
                else
                {
                    Console.WriteLine("\nPlayer 2 turn");
                    mark = 'O';
                }
                Console.Write("Your choice?: ");
                choice = int.Parse(Console.ReadLine());
                board.SetChoice(choice, mark);
                flag = board.CheckWin();
            }
            while(flag  != 1 && flag != -1);

            Console.Clear();
            if(flag == 1)
            {
                Console.WriteLine("Player {0} has won!", (board.GetTurn() % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.Write("\n");
            board.Show();
            Console.ReadLine();

        }
    }
}