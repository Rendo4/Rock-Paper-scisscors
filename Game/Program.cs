 using System;
 using Game;

 public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Rock, Paper scisscors");
      Console.WriteLine("Player one enter rock, paper, or scisscors");
      string playerOneInput = Console.ReadLine();
      Console.WriteLine("Player two enter rock, paper, or scisscors");
      string playerTwoInput = Console.ReadLine();
      PlayGame newGame = new PlayGame(playerOneInput, playerTwoInput);
      newGame.CheckWinner();
      if (newGame.GetWinner() == 1)
      {
        Console.WriteLine("player One Wins");
      } else if (newGame.GetWinner() == 2)
      {
        Console.WriteLine("Player Two Wins");
      } else
      {
        Console.WriteLine("It was a draw");
      }
    }
  }