using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<char> board = new List<char>(){'1','2','3','4','5','6','7','8','9'};
        List<char> player = new List<char>(){'x','o'};
        bool done = false;
        char playerTurn = player[0];
        int numTurn = 1;
        while (!done)
        {
            drawGrid(board);
            makeMark(playerTurn,board);
            if (numTurn >= 5)
            {
                
                done = checkWin(board);
            }

            numTurn++;
            if (numTurn == 10)
            {
                done = true;
            }
        }
        //create varuables
        //start while loop Shile(stillPlaying)

        drawGrid(board);
    }

    static void drawGrid(List<char> board)
    {
        Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
        Console.WriteLine($"--+---+--");
        Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
        Console.WriteLine($"--+---+--");
        Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
    }

    static void makeMark(char currentPlayer,List<char> board)
    {
        Console.WriteLine("Which square would you like to mark?");
        string input = Console.ReadLine();
        int spot = Int32.Parse(input);
        Console.WriteLine(spot);
        Console.WriteLine(currentPlayer);
        Console.WriteLine(board[spot-1]);
        board[spot-1] = currentPlayer;
    }

    static bool checkWin(List<char> board)
    {
        for (int i = 0; i<8; i+=3)
        {
            if (board[i] == board[i+1] && board[i+1] == board[i+2])
            {
                return true;
            }
        }
        if (board[0] == board[4] && board[4] == board[8] ||
            board[2] == board[4] && board[4] == board[6])
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}