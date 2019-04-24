using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using CoinCombinations.Models;

namespace CoinCombinations.Tests
{
  [TestClass]
  public class CoinsTest
  {

    [TestMethod]
    public void CoinsConstructor_CreateInstanceOfCoins_Coins()
    {
      Coins newCoins = new Coins(1);
      Assert.AreEqual(typeof(Coins), newCoins.GetType());
    }

    [TestMethod]
    public void CoinsConstructor_CreateInstanceWithAmount_Coins()
    {
      //Arrange
      int amount = 50;
      Coins newCoins =new Coins(amount);
      // Assert
      Assert.AreEqual (amount , newCoins.GetAmount());
    }

    [TestMethod]
    public void CoinsConstructor_CreateInstanceOfCoins_HasCoinsArray()
    {
     Coins newCoins = new Coins(1);
     int[] expectedOutput = {25, 10, 5, 1};
     CollectionAssert.AreEqual(expectedOutput, newCoins.GetCoinArray());
    }

    [TestMethod]
    public void CalculateChange_UserInputs50_Return2Quarters()
    {
      Coins newCoins = new Coins(50);
      Dictionary<string, int> result = newCoins.CalculateChange();
      Dictionary<string, int> expectedOutput = new Dictionary<string, int>(){{"Q", 2}};
      CollectionAssert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void CalculateChange_UserInputs9_Return1N4P()
    {
      Coins newCoins = new Coins(9);
      Dictionary<string, int> result = newCoins.CalculateChange();
      Dictionary<string, int> expectedOutput = new Dictionary<string, int>(){{"N", 1}, {"P",4}};
      CollectionAssert.AreEqual(expectedOutput, result);
    }


  }
}
