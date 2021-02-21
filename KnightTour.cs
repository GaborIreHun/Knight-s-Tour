using System;


class KnightTour
{
    public static int[,] board = new int[8, 8];

    int rowLenght = board.GetLength(0);
    int colLenght = board.GetLength(1);
    public int userMove;
    public static int horizontalStart;
    public static int verticalStart;
    public int counter = 1;
    public int x;
    public int y;


    // returning counter to allow the reference from KnightToutTest
    public int GetCounter()
    {
        return counter;
    }

    // setting up starting point from horizontal and vectral user input
    public void StartPoint()
    {
        x = horizontalStart - 1;
        y = verticalStart - 1;
        board[x, y] = 4;
    }

    // validating the choosen move to prevent stepping on the same square twice
    public void NextMove()
    {        
        ++counter;
        board[x, y] = 4;
    }    

    // move 1
    public void MoveOne()
    {
        
        if (x < 6 && y > 0)
        {
            
            if (board[x+2, y-1] == 0)
            {
                x += 2;
                y -= 1;
                NextMove();
            }
            else
                Console.WriteLine("You cannot step on the same square twice!!");
        } 
        else
            Console.WriteLine("\n<<< This move would lead the Knight off the board. Try again>>>\n");
    }

    // move 2
    public void MoveTwo()
    {
        
        if (x < 7 && y > 1)
        {
         
            if (board[x+1, y-2] == 0)
            {
                x += 1;
                y -= 2;
                NextMove();
            }
            else
                Console.WriteLine("You cannot step on the same square twice!!");
        }
        else
            Console.WriteLine("\n<<< This move would lead the Knight off the board. Try again>>>");

    }

    // move 3
    public void MoveThree()
    {
        
        if (x > 0 && y > 1)
        {
            if (board[x-1, y-2] == 0)
            {
                x -= 1;
                y -= 2;
                NextMove();
            }
            else
                Console.WriteLine("You cannot step on the same square twice!!");
        }
        else
            Console.WriteLine("\n<<< This move would lead the Knight off the board. Try again>>>");

    }

    // move 4
    public void MoveFour()
    {
        
        if (x > 1 && y > 0)
        {      
            if (board[x-2, y-1] == 0)
            {
                x -= 2;
                y -= 1;
                NextMove();
            }
            else
                Console.WriteLine("You cannot step on the same square twice!!");                
        }
        else
            Console.WriteLine("\n<<< This move would lead the Knight off the board. Try again>>>");

    }

    // move 5
    public void MoveFive()
    {
        
        if (x > 1 && y < 7)
        {
            if (board[x-2, y+1] == 0)
            {
                x -= 2;
                y += 1;
                NextMove();
            }
            else
                Console.WriteLine("You cannot step on the same square twice!!");
        }
        else
            Console.WriteLine("\n<<< This move would lead the Knight off the board. Try again>>>");

    }

    // move 6
    public void MoveSix()
    {
        
        if (x > 0 && y < 6)
        {
            if (board[x-1, y+2] == 0)
            {
                x -= 1;
                y += 2;
                NextMove();
            }
            else
                Console.WriteLine("You cannot step on the same square twice!!");                
        }
        else
            Console.WriteLine("\n<<< This move would lead the Knight off the board. Try again>>>");

    }

    // move 7
    public void MoveSeven()
    {

        if (x < 7 && y < 6)
        {
            if (board[x+1, y+2] == 0)
            {
                x += 1;
                y += 2;
                NextMove();
            }
            else
                Console.WriteLine("You cannot step on the same square twice!!");               
        }
        else
            Console.WriteLine("\n<<< This move would lead the Knight off the board. Try again>>>");
        
    }

    // move 8
    public void MoveEight()
    {
       
        if (x < 6 && y < 7)
        {
            if (board[x+2, y+1] == 0)
            {
                x += 2;
                y += 1;
                NextMove();
            }
            else
                Console.WriteLine("You cannot step on the same square twice!!");
        }
        else
            Console.WriteLine("\n<<< This move would lead the Knight off the board. Try again>>>");
    }

    // creating setter and getter for initial horizontal user input
    public void SetHorizontalStart(int knightTourHorizontalStart)
    {
        horizontalStart = knightTourHorizontalStart;
    }

    public int GetHorizontalStart()
    {
        return horizontalStart;
    }

    // creating setter and getter for initial vertical user input
    public void SetVerticalStart(int knightTourVerticalStart)
    {
        verticalStart = knightTourVerticalStart;
    }

    public int GetVerticalStart()
    {
        return verticalStart;
    }

    // creating setter and getter for user input of choosen move
    public void SetUserMove(int knightTourUserMove)
    {
        userMove = knightTourUserMove;
    }

    public int GetUserMove()
    {
        return userMove;
    }
    
    // creating nested loop to display board
    public void PrintBoard()
    {
        for (int i = 0; i < rowLenght; i++)
        {
            for (int j = 0; j < colLenght; j++)
            {
                Console.Write(string.Format("{0}", board[j, i]));
                Console.Write("  ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("");
        }
    }

    // listing of possible moves
    public void PrintMoves()
    {
        Console.WriteLine("List of moves are:\n" +
            "1. horizontal 2 > vertical -1 ^\n" +
            "2. horizontal 1 > vertical -2 ^\n" +
            "3. horizontal -1 < vertical -2 ^\n" +
            "4. horizontal -2 < vertical -1 ^\n" +
            "5. horizontal -2 < vertical 1 v\n" +
            "6. horizontal -1 < vertical 2 v\n" +
            "7. horizontal 1 > vertical 2 v\n" +
            "8. horizontal 2 > vertical 1 v\n\n");
    }
}

