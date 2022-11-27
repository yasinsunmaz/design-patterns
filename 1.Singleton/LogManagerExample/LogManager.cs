namespace _1.Singleton
{
  /// <summary>
  /// <title>Singleton Tasarım</title>
  /// Singleton bir nesnenin sadece bir örneğinin olduğundan emin olmak ve bu nesneye ihtiyacınız olduğunda kodunuzda her yerde aynı (ve tek örneğin) çağırılmasını sağlamak için kullanılır.
  /// Singleton uygulanacak sınıfın constructor metodu private yapılır.
  /// Sınıfın içinde kendi türünden static bir sınıf tanımlanır.
  /// Tanımlanan bu sınıfa erişebilmek için bir metod sınıfa eklenir.
  /// </summary>

  /// <summary>
  /// <title>Lock Amacı</title>
  /// İki farklı nesne oluşmasını önlemek için Lock anahtar sözcüğünü kullanıyoruz.
  /// Lock ile aynı anda sadece bir thread’in kod bloğu içerisine girmesine izin veriyoruz.
  /// createAsSingletonLogManager() metodu aynı anda iki thread tarafından çağrılsa bile, Lock bloğunda threadlerden biri, diğer thread’in işi tamamlanıncaya kadar bekleyecektir.
  /// İlk thread'ın işi bittiğinde logManager oluştuğu için ikinci thread bloğa girmeyecek ve tek bir nesne oluşmuş olacak.
  /// </summary>
  public class LogManager
  {
    // Singleton uygulanacak sınıfın constructor metodu private yapılır.
    // Yapıcı metodu private olan sınıflar sadece kendi içerisinden new()'lenebilir.
    private LogManager()
    { }

    // Sınıfın içinde kendi türünden static bir sınıf tanımlanır.
    private static LogManager? logManager;

    private static object lockObject = new object();

    // Tanımlanan bu sınıfa erişebilmek için bir metod sınıfa eklenir.
    // Her yeni nesne oluşturmak istediğimizde kullanacağımı metot
    public static LogManager createAsSingletonLogManager()
    {
      lock (lockObject)
      {
        if (logManager == null)
          logManager = new LogManager();
      }

      return logManager;
    }

    public void Info(string message)
    {
      Console.WriteLine($"Info - {message}");
    }

    public void Debug(string message)
    {
      Console.WriteLine($"Debug - {message}");
    }

    public void Error(string message)
    {
      Console.WriteLine($"Error - {message}");
    }

    public void Fatal(string message)
    {
      Console.WriteLine($"Fatal - {message}");
    }

    public void Warn(string message)
    {
      Console.WriteLine($"Warn - {message}");
    }
  }
}