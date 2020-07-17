using System.Collections.Generic; 
using System; 

namespace TheBoulangerie.Models
{
  public class Pastry
  {
  public int PastryAmount {get;}

    public Pastry (int pastryAmount)
      {
        PastryAmount = pastryAmount;
      }
     public int CalculatePastryPrice(int pastryAmount) 
      { 
        if (PastryAmount% 3 == 0)
{
return (PastryAmount*2)-(PastryAmount/3);
}
else if (PastryAmount% 3 == 1)
{
return ((PastryAmount*2)-((PastryAmount-1)/3));
}
else
{
return ((PastryAmount*2)-((PastryAmount-2)/3));
}
    }
    }
  }
