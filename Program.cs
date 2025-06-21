namespace Donusumler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dönüşüm Türleri
            //Implicit Conversion (Örtük Dönüşüm)
            //Explicit Conversion (Açık Dönüşüm)
            //Parse ve TryParse Metotları
            //Convert Sınıfı
            int sayi = 10; // int türünde bir değişken tanımladık
            long uzunSayi = sayi; // int türünden long türüne örtük dönüşüm yapıldı (Implicit Conversion)
            Console.WriteLine($"Örtük Dönüşüm: {uzunSayi}"); // Çıktı: 10
            Console.WriteLine(
                $"Örtük Dönüşüm: {sayi}"); // Çıktı: 10
            Console.WriteLine(
                $"Örtük Dönüşüm: {sayi.GetType()}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"Örtük Dönüşüm: {uzunSayi.GetType()}"); // Çıktı: System.Int64
            Console.WriteLine(
                $"Örtük Dönüşüm: {sayi.GetType().Name}"); // Çıktı: Int32
            Console.WriteLine(
                $"Örtük Dönüşüm: {uzunSayi.GetType().Name}"); // Çıktı: Int64
            Console.WriteLine(
                $"Örtük Dönüşüm: {sayi.GetType().FullName}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"Örtük Dönüşüm: {uzunSayi.GetType().FullName}"); // Çıktı: System.Int64
            Console.WriteLine(
                $"Örtük Dönüşüm: {sayi.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            Console.WriteLine(
                $"Örtük Dönüşüm: {uzunSayi.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int64, Version=
            // Açık Dönüşüm (Explicit Conversion)
            double ondalikSayi = 10.5; // double türünde bir değişken tanımladık
            int tamSayi = (int)ondalikSayi; // double türünden int türüne açık dönüşüm yapıldı (Explicit Conversion)
            Console.WriteLine($"Açık Dönüşüm: {tamSayi}"); // Çıktı: 10
            Console.WriteLine(
                $"Açık Dönüşüm: {ondalikSayi}"); // Çıktı: 10.5
            Console.WriteLine(
                $"Açık Dönüşüm: {ondalikSayi.GetType()}"); // Çıktı: System.Double
            Console.WriteLine(
                $"Açık Dönüşüm: {tamSayi.GetType()}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"Açık Dönüşüm: {ondalikSayi.GetType().Name}"); // Çıktı: Double
            Console.WriteLine(
                $"Açık Dönüşüm: {tamSayi.GetType().Name}"); // Çıktı: Int32
            Console.WriteLine(
                $"Açık Dönüşüm: {ondalikSayi.GetType().FullName}"); // Çıktı: System.Double
            Console.WriteLine(
                $"Açık Dönüşüm: {tamSayi.GetType().FullName}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"Açık Dönüşüm: {ondalikSayi.GetType().AssemblyQualifiedName}"); // Çıktı: System.Double, Version=
            Console.WriteLine(
                $"Açık Dönüşüm: {tamSayi.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            // Parse ve TryParse Metotları
            string sayiString = "123"; // string türünde bir sayı tanımladık
            int sayiParse = int.Parse(sayiString); // string türünden int türüne parse metodu ile dönüşüm yapıldı
            Console.WriteLine($"Parse Metodu: {sayiParse}"); // Çıktı: 123
            Console.WriteLine(
                $"Parse Metodu: {sayiString}"); // Çıktı: 123
            Console.WriteLine(
                $"Parse Metodu: {sayiString.GetType()}"); // Çıktı: System.String
            Console.WriteLine(
                $"Parse Metodu: {sayiParse.GetType()}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"Parse Metodu: {sayiString.GetType().Name}"); // Çıktı: String
            Console.WriteLine(
                $"Parse Metodu: {sayiParse.GetType().Name}"); // Çıktı: Int32
            Console.WriteLine(
                $"Parse Metodu: {sayiString.GetType().FullName}"); // Çıktı: System.String
            Console.WriteLine(
                $"Parse Metodu: {sayiParse.GetType().FullName}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"Parse Metodu: {sayiString.GetType().AssemblyQualifiedName}"); // Çıktı: System.String, Version=
            Console.WriteLine(
                $"Parse Metodu: {sayiParse.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            // TryParse Metodu
            string sayiString2 = "456a"; // string türünde bir sayı tanımladık (hatalı)
            int sayiTryParse;
            bool basarili = int.TryParse(sayiString2, out sayiTryParse); // TryParse metodu ile dönüşüm yapıldı
                
            if (basarili)
            {
                Console.WriteLine($"TryParse Metodu Başarılı: {sayiTryParse}"); // Çıktı: 456
            }
            else
            {
                Console.WriteLine("TryParse Metodu Başarısız: Hatalı sayı formatı"); // Çıktı: Hatalı sayı formatı
            }
            Console.WriteLine(
                $"TryParse Metodu: {sayiString2}"); // Çıktı: 456a
            Console.WriteLine(
                $"TryParse Metodu: {sayiString2.GetType()}"); // Çıktı: System.String
            Console.WriteLine(
                $"TryParse Metodu: {sayiTryParse.GetType()}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"TryParse Metodu: {sayiString2.GetType().Name}"); // Çıktı: String
            Console.WriteLine(
                $"TryParse Metodu: {sayiTryParse.GetType().Name}"); // Çıktı: Int32
            Console.WriteLine(
                $"TryParse Metodu: {sayiString2.GetType().FullName}"); // Çıktı: System.String
            Console.WriteLine(
                $"TryParse Metodu: {sayiTryParse.GetType().FullName}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"TryParse Metodu: {sayiString2.GetType().AssemblyQualifiedName}"); // Çıktı: System.String, Version=
            Console.WriteLine(
                $"TryParse Metodu: {sayiTryParse.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            // Convert Sınıfı
            string sayiString3 = "789"; // string türünde bir sayı tanımladık
            int sayiConvert = Convert.ToInt32(sayiString3); // Convert sınıfı ile dönüşüm yapıldı
            Console.WriteLine($"Convert Sınıfı: {sayiConvert}"); // Çıktı: 789
            Console.WriteLine(
                $"Convert Sınıfı: {sayiString3}"); // Çıktı: 789
            Console.WriteLine(
                $"Convert Sınıfı: {sayiString3.GetType()}"); // Çıktı: System.String
            Console.WriteLine(
                $"Convert Sınıfı: {sayiConvert.GetType()}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"Convert Sınıfı: {sayiString3.GetType().Name}"); // Çıktı: String
            Console.WriteLine(
                $"Convert Sınıfı: {sayiConvert.GetType().Name}"); // Çıktı: Int32
            Console.WriteLine(
                $"Convert Sınıfı: {sayiString3.GetType().FullName}"); // Çıktı: System.String
            Console.WriteLine(
                $"Convert Sınıfı: {sayiConvert.GetType().FullName}"); // Çıktı: System.Int32
            Console.WriteLine(
                $"Convert Sınıfı: {sayiString3.GetType().AssemblyQualifiedName}"); // Çıktı: System.String, Version=
            Console.WriteLine(
                $"Convert Sınıfı: {sayiConvert.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            // Convert sınıfı ile dönüşümde hata oluşursa, bir istisna fırlatılır
            
            try
            {
                string hataliSayiString = "123abc"; // Hatalı bir string tanımladık
                int hataliSayiConvert = Convert.ToInt32(hataliSayiString); // Hata oluşacak
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}"); // Çıktı: Hata: Input string was not in a correct format.
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Hata: {ex.Message}"); // Çıktı: Hata: Value was either too large or too small for an Int32.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Beklenmeyen Hata: {ex.Message}"); // Çıktı: Beklenmeyen Hata: ...
            }


        }
    }
}
