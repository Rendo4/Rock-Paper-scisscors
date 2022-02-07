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
    public string GetPlayerTwo()
    {
      return _playerTwo;
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
}