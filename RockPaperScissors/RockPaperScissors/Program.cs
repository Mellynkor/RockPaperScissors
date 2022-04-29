using System;
public class RockPaperScissors
{

    // 0 = Rock
    // 1 = Paper
    // 2 = Scissors

    public static void Main()
    {
        int gg = 0;
        int playerScore = 0;
        int computerScore = 0;

        Random random = new Random();
        var computerChoice = 0;

        Console.WriteLine("Welcome to Rock Paper Scissors");
        Console.WriteLine("Press enter to continue");
        Console.ReadKey();

        Console.WriteLine("This game works on a best of three basis");
        Console.WriteLine("You can input rock, paper, or scissors each round.");

        while (gg == 0)
        {
            if (playerScore == 3)
            {
                Console.WriteLine("You win!");
                Console.ReadKey();

            }
            if (computerScore == 3)
            {
                Console.WriteLine("The computer wins!");
                Console.ReadKey();
            }
            else
            Console.WriteLine("When I say GO, input your choice.");
            Console.WriteLine("3");
            Console.WriteLine("2");
            Console.WriteLine("1");
            Console.WriteLine("Go!");

            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case ("rock"):
                    computerChoice = random.Next(0, 2);
                    if (computerChoice == 0)
                    {
                        Console.WriteLine("You both played Rock, it's a tie!");
                        Console.ReadKey();
                    }
                    if (computerChoice == 1)
                    {
                        Console.WriteLine("The computer played paper, you lose this round!");
                        computerScore++;
                        Console.ReadKey();
                    }
                    if (computerChoice == 2)
                    {
                        Console.WriteLine("The computer played scissors, you won this round!");
                        playerScore++;
                        Console.ReadKey();
                    }

                    break;

                case ("paper"):
                    computerChoice = random.Next(0, 2);
                    if (computerChoice == 0)
                    {
                        Console.WriteLine("The computer played Rock, you win this round!");
                        playerScore++;
                        Console.ReadKey();
                    }
                    if (computerChoice == 1)
                    {
                        Console.WriteLine("The computer played paper, it's a tie!");
                        Console.ReadKey();
                    }
                    if (computerChoice == 2)
                    {
                        Console.WriteLine("The computer played scissors, you lose this round!");
                        computerScore++;
                        Console.ReadKey();
                    }
                    break;

                case ("scissors"):
                    computerChoice = random.Next(0, 2);
                    if (computerChoice == 0)
                    {
                        Console.WriteLine("The computer played Rock, you lose this round!");
                        computerScore++;
                        Console.ReadKey();
                    }
                    if (computerChoice == 1)
                    {
                        Console.WriteLine("The computer played paper, you win this round!");
                        playerScore++;
                        Console.ReadKey();
                    }
                    if (computerChoice == 2)
                    {
                        Console.WriteLine("The computer played scissors, it's a tie!");
                        Console.ReadKey();
                    }
                    break;
            }
        }

    }

}