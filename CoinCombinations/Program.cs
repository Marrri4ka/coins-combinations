using System;
using System.Collections.Generic;

namespace  CoinCombinations.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter amount in cents!");
      string userInput = Console.ReadLine();
      if(int.TryParse(userInput, out int amount) && amount > 0)
      {
        Coins newCoins = new Coins(amount);
        Dictionary<string,int> newDictionary = newCoins.CalculateChange();
        foreach (KeyValuePair<string,int> coin in newDictionary)
        {
          Console.WriteLine(coin.Key + ": " + coin.Value);
        }
      }
      else
      {
        Console.WriteLine("I'm sorry, that's not a valid amount.");
        Main();
      }
    }
  }
}
