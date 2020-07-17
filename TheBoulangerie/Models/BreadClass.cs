namespace TheBoulangerie
{
  public class BreadClass
  {
    public int BreadAmount = 0; 
     private int CalculateBreadPrice() 
    {
      if (BreadAmount % 3 == 0)
      {
        return (BreadAmount*5)-(BreadAmount/3);
      }
      else if (BreadAmount%3 == 1)
      {
        return (BreadAmount*5)-(BreadAmount/3)+5;
      }
      else
      {
        return (BreadAmount*5)-(BreadAmount/3)+10;
      }
    }

    }
 
}
