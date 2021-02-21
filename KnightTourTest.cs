using System;


class KnightTourTest
{
    static void Main()
    {

        KnightTour knightTour = new KnightTour();


        Console.WriteLine("\t\t<<<<<<<<  Welcome to the Knight Tour Game >>>>>>>>\n\n");

        Console.WriteLine("The aim of the game is to walk the Knight through the board,\nwhile only stepping once on each of the squares.\n\n");

        knightTour.PrintMoves();


        Console.Write("Please enter the preferred horizontal position to start(1-8): ");
        int knightTourtheHorizontalStart = int.Parse(Console.ReadLine());
        knightTour.SetHorizontalStart(knightTourtheHorizontalStart);

        Console.Write("Please enter the preferred vertical position to start(1-8): ");
        int knightTourtheVerticalStart = int.Parse(Console.ReadLine());
        knightTour.SetVerticalStart(knightTourtheVerticalStart);

        knightTour.StartPoint();

        knightTour.PrintBoard();


        do
        {
            Console.Write("Please enter the number of the move you attempt to make(1-8 or 0 for List of moves and 9 to exit: ");
            int knightTourtheUserMove = int.Parse(Console.ReadLine());
            knightTour.SetUserMove(knightTourtheUserMove);
            Console.WriteLine("");

            if (knightTour.GetCounter() == 10)
                Console.WriteLine("You are getting warmed up...10 moves already...\n");
            else if (knightTour.GetCounter() == 20)
                Console.WriteLine("Not bad, carry on!..20 moves so far..\n");
            else if (knightTour.GetCounter() == 32)
                Console.WriteLine("Gosh, 32 moves...you are half way there!\n");
            else if (knightTour.GetCounter() == 48)
                Console.WriteLine("48 moves...Fabolous, you are almost there!\n");
            else if (knightTour.GetCounter() == 64)
            {
                Console.WriteLine("\t\t<<<<<<<< Congratulation!!! You Win!!! >>>>>>>>");
                knightTourtheUserMove = 9;
            }

            if (knightTourtheUserMove == 0)
                knightTour.PrintMoves();

            switch (knightTour.GetUserMove())
            {
                case 1:
                    knightTour.MoveOne();
                    break;
                case 2:
                    knightTour.MoveTwo();
                    break;
                case 3:
                    knightTour.MoveThree();
                    break;
                case 4:
                    knightTour.MoveFour();
                    break;
                case 5:
                    knightTour.MoveFive();
                    break;
                case 6:
                    knightTour.MoveSix();
                    break;
                case 7:
                    knightTour.MoveSeven();
                    break;
                case 8:
                    knightTour.MoveEight();
                    break;
            }

            knightTour.PrintBoard();

        } while (knightTour.GetUserMove() != 9);
        

        knightTour.PrintBoard();
    }

    
}

