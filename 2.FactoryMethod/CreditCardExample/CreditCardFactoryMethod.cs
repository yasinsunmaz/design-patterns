using _2.FactoryMethod.CreditCardExample.Cards;
using _2.FactoryMethod.PrinterExample.Enums;
using _2.FactoryMethod.PrinterExample.Interfaces;
using _2.FactoryMethod.PrinterExample.Printers;

namespace _2.FactoryMethod.PrinterExample
{
  /// <summary>
  ///  Factory Method, üst sınıfta nesneler oluşturmak için bir arabirim sağlayan, ancak alt sınıfların oluşturulacak
  ///  bu nesne türünü değiştirmesine izin veren bir yaratımsal desen (creational pattern) türüdür.
  /// </summary>
  public class CreditCardFactoryMethod : ICreditCardFactoryMethod
  {
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