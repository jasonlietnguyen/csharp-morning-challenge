using System;

namespace ConsoleApplication
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var maxNumber = 0;

      if (args.Length > 0)
      {
        Int32.TryParse(args[0], out maxNumber);
      }

      var game = maxNumber > 0 ? new Game(maxNumber) : new Game();

      game.Play();

      Console.Clear();
    }
  }
}