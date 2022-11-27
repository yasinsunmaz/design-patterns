using _2.FactoryMethod.PrinterExample.Enums;

namespace _2.FactoryMethod.PrinterExample.Interfaces
{
  public interface ICreditCardFactoryMethod
  {
    ICreditCard GetCard(ECreditCardType printerType);

    string GetCardInfo(string cardType, int limit, int annualCharge);
  }
}