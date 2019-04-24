using System;
using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class Coins // class
  {
   private int _amount; // Field

   private int[] _coinArray = new int[] {25, 10, 5, 1};
   private string[] _coinNominals = new string[] {"Q","D","N","P"};

   public Coins (int amount) // constructor
   {
     _amount = amount;
   }

   public int GetAmount()
   {
     return _amount;
   }

   public int[] GetCoinArray()
   {
     return _coinArray;
   }

   public Dictionary<string,int> CalculateChange()
   {
     Dictionary<string,int> output = new Dictionary<string,int>(){};
     int tempAmount = _amount;
     for (int i =0; i < _coinArray.Length; i++)
     {
       if (tempAmount > _coinArray[i])
       {
         output[_coinNominals[i]] = tempAmount/_coinArray[i];
         tempAmount = tempAmount % _coinArray[i];
       }
     }







     return  output;
   }
  }
}
