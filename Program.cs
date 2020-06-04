using System;
using System.Collections.Generic;
using System.Linq;

namespace blackjack_app
{
  class Program
  {
    private const string anothergamePrompt = "Would you like to play another game? (Y/N): ";
    static void Main(string[] args)
    {
      var keepPlaying = true;

      while (keepPlaying)
      {
        var game = new Game();
        game.Play();
        Console.WriteLine(anothergamePrompt);
        var playAgainString = Console.ReadLine();
        keepPlaying = (playAgainString == "Y");
      }

      Console.WriteLine();
      Console.WriteLine("Thank you for playing");
    }
  }
}
