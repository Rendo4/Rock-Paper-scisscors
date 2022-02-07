using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Tests 
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void isPlayerInputsRead()
    {
      PlayGame newGame = new PlayGame("rock", "paper");
      Assert.AreEqual("rock", newGame.GetPlayerOne());
      Assert.AreEqual("paper", newGame.GetPlayerTwo());
    }
    [TestMethod]
    public void testDeterminingWinner()
    {
      PlayGame newGame = new PlayGame("rock", "paper");
      newGame.CheckWinner();
      Assert.AreEqual(2, newGame.GetWinner());
    }
  }
}