using _2.FactoryMethod.BankAccountType.Interfaces;

namespace _2.FactoryMethod.BankAccountType
{
  public class AccountFactory : IAccountFactory
  {
    public AccoutType GetAccoutType(string accountName)
    {
      if (accountName.Equals("SAVING", StringComparison.OrdinalIgnoreCase))
      {
        return new SavingsAccount();
      }
      else if (accountName.Equals("CURRENT", StringComparison.OrdinalIgnoreCase))
      {
        return new CurrentAccount();
      }
      else
      {
        throw new ArgumentException("Tanımsız banka tipi");
      }
    }
  }
}