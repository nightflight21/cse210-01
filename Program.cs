//Author: Brandon de Leon
//Assignment: Tic Tac Toe

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<char> board = new List<char>(){'1','2','3','4','5','6','7','8','9'};
        List<char> player = new List<char>(){'x','o'};
        bool done = false;
        int numTurn = 0;
        while (!done)
        {
            drawGrid(board);
            makeMark(player[numTurn%2],board);
            if (numTurn >= 4)
            {
                done = checkWin(board);
                if (done)
                {
                    Console.WriteLine($"player {player[numTurn%2]} wins!");
                }
            }

            numTurn++;
            if (numTurn == 9)
            {
                done = true;
                Console.WriteLine("no one wins");
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
        board[spot-1] = currentPlayer;
    }

    static bool checkWin(List<char> board)
    {
        if (board[0] == board[4] && board[4] == board[8] ||
            board[2] == board[4] && board[4] == board[6] ||
            board[0] == board[1] && board[1] == board[2] ||
            board[3] == board[4] && board[4] == board[5] ||
            board[6] == board[7] && board[7] == board[8] ||
            board[0] == board[3] && board[3] == board[6] ||
            board[1] == board[4] && board[4] == board[7] ||
            board[2] == board[5] && board[5] == board[8])
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}