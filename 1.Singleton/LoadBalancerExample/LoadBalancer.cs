namespace _1.Singleton
{
  public class LoadBalancer
  {
    // Uygulama çalıştığında tüm istekleri yükler
    private static readonly LoadBalancer instance = new LoadBalancer();

    private readonly List<Server> servers;
    private readonly Random random = new Random();

    // Singleton uygulanacak sınıfın constructor metodu 'private' yapılır.
    private LoadBalancer()
    {
      // Kullanılabilir sunucu listesini yükle
      servers = new List<Server>
                {
                  new Server{ Name = "ServerI", IP = "198.13.220.13" },
                  new Server{ Name = "ServerII", IP = "198.13.220.56" },
                  new Server{ Name = "ServerIII", IP = "198.13.220.09" },
                  new Server{ Name = "ServerIV", IP = "198.13.220.06" },
                  new Server{ Name = "ServerV", IP = "198.13.220.35" },
                };
    }

    public static LoadBalancer GetLoadBalancer()
    {
      return instance;
    }

    // Rastgele bir sunucu seçimi
    public Server NextServer
    {
      get
      {
        int r = random.Next(servers.Count);
        return servers[r];
      }
    }
  }
}