using System;

namespace csharp_intro
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");

      // var x = "My name is Jason";
      // Console.WriteLine(x);

      // for (int i = 0; i < 10; i++)
      // {
      //     Console.WriteLine(i);
      // }

      // int num = 100;
      // num -= 50;
      // Console.WriteLine(num);

      // decimal a = 0.133453453435m;
      // int b = 3;
      // string abc =  b + a + "hello";
      // Console.WriteLine(abc);

      var playAgain = 1;
      while (playAgain == 1)
      {
        int number = new Random().Next(1, 2);
        play(number);
        Console.WriteLine("Would you like to play again? 1 = Yes!");
        var response = Console.ReadLine();
        Int32.TryParse(response, out playAgain);
      }
      
      Console.Clear();

    }

    static void play(int number)
    {
      var correct = false;
      var count = 0;

      while (!correct)
      {
        Console.WriteLine("Take a Guess");

        var guess = Console.ReadLine();
        var guessNumber = 0;
        Int32.TryParse(guess, out guessNumber);
        count++;

        if (guessNumber == number)
        {
          correct = true;
          Console.WriteLine("Correct!");
          Console.WriteLine("It only took you {0} guesses!", count);
        }
        else
        {
          Console.WriteLine("Wrong");
        }
      }
    }
  }
}
