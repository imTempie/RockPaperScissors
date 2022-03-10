using System;

class MainClass {
  public static void Main (string[] args) {
    string inputPlayer, inputCPU;
    int randomInt;

    bool playAgain = true;

    while (playAgain)
    {
      int scorePlayer = 0;
      int scoreCPU = 0;

      while (scorePlayer < 3 && scoreCPU < 3)
      {
        Console.Write("Choose between ROCK, PAPER and SCISSORS:     ");
        inputPlayer = Console.ReadLine();
        inputPlayer = inputPlayer.ToUpper();

        Random rnd = new Random();

        randomInt = rnd.Next(1, 4);

        switch (randomInt)
        {
          case 1:
            inputCPU = "ROCK";
            Console.WriteLine("Computer chose ROCK");
            if (inputPlayer == "ROCK")
            {
              Console.WriteLine("DRAW!");
            }
            else if (inputPlayer == "PAPER")
            {
              Console.WriteLine("Player Wins!");
              scorePlayer++;
            }
            else if (inputPlayer == "SCISSORS")
            {
              Console.WriteLine("CPU Wins!");
              scoreCPU++;
            }
            break;
          case 2:
            inputCPU = "PAPER";
            Console.WriteLine("Computer chose PAPER");
            if (inputPlayer == "PAPER")
            {
              Console.WriteLine("DRAW!");
            }
            else if (inputPlayer == "ROCK")
            {
              Console.WriteLine("CPU Wins!");
              scorePlayer++;
            }
            else if (inputPlayer == "SCISSORS")
            {
              Console.WriteLine("PLAYER Wins!");
              scoreCPU++;
            }
            break;
          case 3:
            inputCPU = "SCISSORS";
            Console.WriteLine("Computer chose SCISSORS");
            if (inputPlayer == "SCISSORS")
            {
              Console.WriteLine("DRAW!");
            }
            else if (inputPlayer == "ROCK")
            {
              Console.WriteLine("Player Wins!");
              scorePlayer++;
            }
            else if (inputPlayer == "PAPER")
            {
              Console.WriteLine("CPU Wins!");
              scoreCPU++;
            }
            break;  
          default:
            Console.WriteLine("Invalid Entry!");
            break;  
       
        }
          Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
      }
        if (scorePlayer == 3)
        {
          Console.WriteLine("Player Won!");
        }
        else if (scoreCPU == 3)
        {
          Console.WriteLine("Computer Won!");
        }
        else
        {

        }

        Console.WriteLine("Do you want to play again? (y/n)");
        string loop = Console.ReadLine();
        if (loop == "y")
        {
          playAgain = true;
          Console.Clear();
        }
        else if (loop == "n")
        {
          playAgain = false;
        }
    }

  }

}
