using _2.FactoryMethod.CreditCardExample.Cards;
using _2.FactoryMethod.PrinterExample.Enums;
using _2.FactoryMethod.PrinterExample.Interfaces;
using _2.FactoryMethod.PrinterExample.Printers;

namespace _2.FactoryMethod.PrinterExample
{
  public class CreditCardFactoryMethodWithSingleton : ICreditCardFactoryMethod
  {
    private CreditCardFactoryMethodWithSingleton()
    { }

    private static CreditCardFactoryMethodWithSingleton? creditCard;

    private static object lockObject = new object();

    public static CreditCardFactoryMethodWithSingleton createAsCreditCardFactoryMethodWithSingleton()
    {
      lock (lockObject)
      {
        if (creditCard == null)
          creditCard = new CreditCardFactoryMethodWithSingleton();
      }

      return creditCard;
    }

    public ICreditCard GetCard(ECreditCardType creditCardType)
    {
      ICreditCard? creditCard = null;
      switch (creditCardType)
      {
        case ECreditCardType.Silver:
          creditCard = new Silver();
          break;

        case ECreditCardType.Gold:
          creditCard = new Gold();
          break;

        case ECreditCardType.Platinum:
          creditCard = new Platinum();
          break;

        default:
          throw new NotImplementedException();
      }
      return creditCard;
    }

    public string GetCardInfo(string cardType, int limit, int annualCharge)
    {
      return "Kart tipi: " + cardType + ", Kart limiti: " + limit + ", Kart Yıllık Ücreti: " + annualCharge;
    }
  }
}