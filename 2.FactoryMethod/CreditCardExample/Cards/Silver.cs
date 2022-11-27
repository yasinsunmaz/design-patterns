using _2.FactoryMethod.PrinterExample.Interfaces;

namespace _2.FactoryMethod.CreditCardExample.Cards
{
  public class Silver : ICreditCard
  {
    public int GetAnnualCharge()
    {
      return 130;
    }

    public string GetCardType()
    {
      return "Silver Basic";
    }

    public int GetCreditLimit()
    {
      return 5000;
    }
  }
}