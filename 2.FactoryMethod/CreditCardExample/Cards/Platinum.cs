using _2.FactoryMethod.PrinterExample.Interfaces;

namespace _2.FactoryMethod.PrinterExample.Printers
{
  public class Platinum : ICreditCard
  {
    public int GetAnnualCharge()
    {
      return 500;
    }

    public string GetCardType()
    {
      return "Platinum Plus";
    }

    public int GetCreditLimit()
    {
      return 50000;
    }
  }
}