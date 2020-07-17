using System; 
using System.Collections.Generic;
using TheBoulangerie.Models; 

namespace TheBoulangerie 
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Le Boulangerie. Today we are offering loaves of bread for $5 or Buy 2 get 1 Free. We also have pastries. These are $2 each or 3 for $5");
      Console.WriteLine("Would you like to make a purchase? If so click '1' ");
      string response = Console.ReadLine(); 

      if (response == "1")
      {
        Console.WriteLine("Please enter the amount of bread you would like.");
        string quantityBread = Console.ReadLine(); 
        int intBread = Convert.ToInt32(quantityBread) ;
        Bread breadOrder = new Bread (intBread);
        int priceBread = breadOrder.CalculateBreadPrice(intBread);
        Console.WriteLine("You have ordered " + intBread + " loaves of bread. This totals:$ " + priceBread);
        Console.WriteLine("Would you like to order any pastries? If so, click 2");
        string continueOrder = Console.ReadLine();
        if(continueOrder == "2")
        {
          Console.WriteLine("How many pastries would you like?");
          string quantityPastry = Console.ReadLine(); 
          int intPastry = Convert.ToInt32(quantityPastry) ;
          Pastry pastryOrder = new Pastry (intPastry);
          int pricePastry = pastryOrder.CalculatePastryPrice(intPastry);
          Console.WriteLine("You have ordered " + intBread + " loaves of bread. As well as " + quantityPastry + "Pastries. This totals:$ " + (priceBread+pricePastry));
          
        } else
        {
          Console.WriteLine("Thanks for your order!");
        } 
      }
      else
      {
        Console.WriteLine("Thanks for stopping by!");
      }
    }
  }
}