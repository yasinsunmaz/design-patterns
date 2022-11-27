using _1.Singleton;

// LogManager - Singleton Tasarım Örneği
Console.WriteLine("*** LogManager - Singleton Tasarım Örneği ***");
LogManager logFirst = LogManager.createAsSingletonLogManager();
logFirst.Info("Sistemde uyarı!");
logFirst.Debug("Kayıt edildi.");

LogManager logSecond = LogManager.createAsSingletonLogManager();
logSecond.Warn("Bir sorun oluştur.");

LogManager logThird = LogManager.createAsSingletonLogManager();
logThird.Fatal("Kritik hata mevcut!");

// Nesnenleri karşılaştırma
if (logFirst.Equals(logSecond) && logSecond.Equals(logThird))
{
  Console.WriteLine("LogManager - Aynı nesneler.");
}
else
{
  Console.WriteLine("Aynı nesneler değildir!");
}

Console.WriteLine();

// LoadBalancer Örneği
Console.WriteLine("*** LoadBalancer Örneği ***");
var lb1 = LoadBalancer.GetLoadBalancer();
var lb2 = LoadBalancer.GetLoadBalancer();
var lb3 = LoadBalancer.GetLoadBalancer();
var lb4 = LoadBalancer.GetLoadBalancer();
// Nesnenleri karşılaştırma
if (lb1 == lb2 && lb2 == lb3 && lb3 == lb4)
{
  Console.WriteLine("LoadBalancer - Aynı nesneler.");
}

// Ardından, bir sunucu için 20 isteğin yükünü dengeleyin
var balancer = LoadBalancer.GetLoadBalancer();
for (int i = 0; i < 20; i++)
{
  string serverName = balancer.NextServer.Name;
  Console.WriteLine("İsteği buraya gönder: " + serverName);
}

Console.ReadKey();