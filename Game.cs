using System;

namespace ConsoleApplication
{
  public class Game
  {
    public int MaxNumber { get; private set; }

    public Game() : this(20)
    {

    }

    public Game(int maxNumber)
    {
      MaxNumber = maxNumber;
    }

    public void Play()
    {
      var playAgain = 1;

      while (playAgain == 1)
      {
        var number = new Random().Next(1, MaxNumber);

        gameLoop(number);

        Console.WriteLine("Would you like to play again? 1 = yes.");

        var response = Console.ReadLine();

        Int32.TryParse(response, out playAgain);
      }
    }

    private void gameLoop(int number)
    {
      var correct = false;
      var count = 0;

      Console.Clear();
      Console.WriteLine("Try to guess a number from 1 to {0}.", MaxNumber);

      while (!correct)
      {
        var guess = Console.ReadLine();
        var guessNumber = 0;

        Int32.TryParse(guess, out guessNumber);

        count++;

        if (guessNumber == 0)
        {
          return;
        }

        if (guessNumber == number)
        {
          correct = true;

          Console.WriteLine("Correct!");
          Console.WriteLine("It only took you {0} guesses!", count);
        }
        else
        {
          Console.WriteLine("Wrong!");
          Console.WriteLine("Guess again.");
        }
      }
    }
  }
}