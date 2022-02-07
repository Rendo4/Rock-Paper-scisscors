using System;

namespace Game
{
  public class PlayGame
  {
    private string _playerOne;
    private string _playerTwo;
    private int _winner;

    public PlayGame(string playerOneInput, string playerTwoInput)
    {
      _playerOne = playerOneInput;
      _playerTwo = playerTwoInput;
      _winner = 3;
    }

    public string GetPlayerOne()
    {
      return _playerOne;
    }
    public void SetPlayerOne(string playerOneInput)
    {
      _playerOne = playerOneInput;
    }

    public string GetPlayerTwo()
    {
      return _playerTwo;
    }
    public void SetPlayerTwo(string playerTwoInput)
    {
      _playerTwo = playerTwoInput;
    }
    public int GetWinner()
    {
      return _winner;
    }
    public void CheckWinner()
    {
      if (_playerOne == "rock")
      {
        if (_playerTwo == "paper")
        {
          _winner = 2;
        } else if ( _playerTwo == "scisscors")
        {
          _winner = 1;
        } else {
          _winner = 3;
        }
      } else if (_playerOne == "scisscors")
      {
        if (_playerTwo ==  "rock")
        {
          _winner = 2;
        }
        else if (_playerTwo == "paper")
        {
          _winner = 1;
        } else {
          _winner = 3;
        }
      } else 
      {
        if (_playerTwo == "scisscors")
        {
          _winner = 2;
        } else if (_playerTwo == "rock")
        {
          _winner = 1;
        } else
        {
          _winner = 3;
        }
      }
    }
  }
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
}