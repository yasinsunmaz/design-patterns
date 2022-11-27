using _2.FactoryMethod.PrinterExample.Interfaces;

namespace _2.FactoryMethod.PrinterExample.Printers
{
  public class Gold : ICreditCard
  {
    public int GetAnnualCharge()
    {
      return 200;
    }

    public string GetCardType()
    {
      return "Gold Card";
    }

    public int GetCreditLimit()
    {
      return 10000;
    }
  }
}