using _2.FactoryMethod.PrinterExample;
using _2.FactoryMethod.PrinterExample.Enums;
using _2.FactoryMethod.PrinterExample.Interfaces;

// CreditCard - FactoryMethod Tasarım Örneği
Console.WriteLine("*** CreditCard - FactoryMethod Tasarım Örneği ***");

var creditCardFactoryMethod = new CreditCardFactoryMethod();
ICreditCard crediCardForSilver = creditCardFactoryMethod.GetCard(ECreditCardType.Silver);
string crediCardInfoForSilver = creditCardFactoryMethod.GetCardInfo(
                                crediCardForSilver.GetCardType(),
                                crediCardForSilver.GetCreditLimit(),
                                crediCardForSilver.GetAnnualCharge());

Console.WriteLine(crediCardInfoForSilver);

ICreditCard crediCardForGold = creditCardFactoryMethod.GetCard(ECreditCardType.Gold);
string crediCardInfoForGold = creditCardFactoryMethod.GetCardInfo(
                                crediCardForGold.GetCardType(),
                                crediCardForGold.GetCreditLimit(),
                                crediCardForGold.GetAnnualCharge());
Console.WriteLine(crediCardInfoForGold);

ICreditCard crediCardForPlatinum = creditCardFactoryMethod.GetCard(ECreditCardType.Platinum);
string crediCardInfoForPlatinum = creditCardFactoryMethod.GetCardInfo(
                                crediCardForPlatinum.GetCardType(),
                                crediCardForPlatinum.GetCreditLimit(),
                                crediCardForPlatinum.GetAnnualCharge());
Console.WriteLine(crediCardInfoForPlatinum);

// CreditCard - FactoryMethod ile Singleton Tasarım Örneği
Console.WriteLine("*** CreditCard - FactoryMethod ile Singleton Tasarım Örneği ***");
CreditCardFactoryMethodWithSingleton creditCardFactoryMethodWithSingleton1 = CreditCardFactoryMethodWithSingleton.createAsCreditCardFactoryMethodWithSingleton();

ICreditCard ccfsFactorSingleton = creditCardFactoryMethodWithSingleton1.GetCard(ECreditCardType.Silver);
string ccfsiFactorSingleton = creditCardFactoryMethodWithSingleton1.GetCardInfo(
                                ccfsFactorSingleton.GetCardType(),
                                ccfsFactorSingleton.GetCreditLimit(),
                                ccfsFactorSingleton.GetAnnualCharge());

Console.WriteLine(ccfsiFactorSingleton);

CreditCardFactoryMethodWithSingleton creditCardFactoryMethodWithSingleton2 = CreditCardFactoryMethodWithSingleton.createAsCreditCardFactoryMethodWithSingleton();
ICreditCard ccfgFactorSingleton = creditCardFactoryMethodWithSingleton2.GetCard(ECreditCardType.Gold);
string ccfgiFactorSingleton = creditCardFactoryMethodWithSingleton2.GetCardInfo(
                                ccfgFactorSingleton.GetCardType(),
                                ccfgFactorSingleton.GetCreditLimit(),
                                ccfgFactorSingleton.GetAnnualCharge());
Console.WriteLine(ccfgiFactorSingleton);

CreditCardFactoryMethodWithSingleton creditCardFactoryMethodWithSingleton3 = CreditCardFactoryMethodWithSingleton.createAsCreditCardFactoryMethodWithSingleton();
ICreditCard ccfpFactorSingleton = creditCardFactoryMethodWithSingleton3.GetCard(ECreditCardType.Platinum);
string ccfpiFactorSingleton = creditCardFactoryMethodWithSingleton3.GetCardInfo(
                                ccfpFactorSingleton.GetCardType(),
                                ccfpFactorSingleton.GetCreditLimit(),
                                ccfpFactorSingleton.GetAnnualCharge());
Console.WriteLine(ccfpiFactorSingleton);