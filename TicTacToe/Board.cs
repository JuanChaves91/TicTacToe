namespace TicTacToe
{
    internal class Board
    {
        private char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private int turn = 1;

        public void Show()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }

        public int CheckWin()
        {
            // Horizontal winning condition
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }

            // Vertical winning condition
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }

            // Diagonal winning condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }

            // Draw?
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public void SetChoice(int choice, char mark)
        {
            if (arr[choice] != 'X' && arr[choice] != 'O')
            {
                if (turn % 2 != 0)
                {
                    arr[choice] = mark;
                    turn++;
                }
                else
                {
                    arr[choice] = mark;
                    turn++;
                }
            }
            else
            {
                Console.WriteLine("Sorry the cell {0} is already marked with {1}", choice, arr[choice]);
                Console.WriteLine("\n");
                Console.WriteLine("Please wait 2 seconds, board is loading again.....");
                Thread.Sleep(2000);
            }
        }

        public int GetTurn()
        {
            return turn;
        }
    }
}