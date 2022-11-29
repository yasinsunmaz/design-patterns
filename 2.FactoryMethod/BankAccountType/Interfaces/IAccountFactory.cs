namespace _2.FactoryMethod.BankAccountType.Interfaces
{
  public interface IAccountFactory
  {
    AccoutType GetAccoutType(string accountName);
  }
}