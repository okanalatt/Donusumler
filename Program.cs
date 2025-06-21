using System.Threading.Channels;

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

            //decimal ya da double veri tipiyle bölme işlemi yapıp ekrana yazdırın
            decimal sayi1 = 10.5m; // decimal türünde bir sayı tanımladık
            decimal sayi2 = 3.2m; // decimal türünde bir sayı tanımladık
            decimal bolum = sayi1 / sayi2; // decimal türünde bölme işlemi yapıldı
            Console.WriteLine($"Decimal Bölme: {bolum}"); // Çıktı: 3.28125
            Console.Write("Ondalık Sayi gir");
            double d1=Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan sayı alıyoruz
            Console.Write("Ondalık Sayi gir");
            double d2 = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan sayı alıyoruz
            double sonuc=d1/d2; // double türünde bölme işlemi yapıldı
            Console.WriteLine(sonuc);
            Console.ReadLine(); // Konsol penceresinin açık kalması için

            //byte veri tipiyle bölme işlemi yapıp ekrana yazdırın
            byte b1 = 10; // byte türünde bir sayı tanımladık
            byte b2 = 3; // byte türünde bir sayı tanımladık
            byte bolumByte = (byte)(b1 / b2); // byte türünde bölme işlemi yapıldı (açık dönüşüm ile)
            Console.WriteLine("Byte tipli deger gir");
            byte b3= Convert.ToByte(Console.ReadLine()); // Kullanıcıdan byte türünde sayı alıyoruz
            byte s = (byte) (b1 / b3);
            Console.WriteLine(s);
            Console.WriteLine($"Byte Bölme: {bolumByte}"); // Çıktı: 3
            Console.WriteLine(
                $"Byte Bölme: {b1} / {b2} = {bolumByte}"); // Çıktı: Byte Bölme: 10 / 3 = 3
            Console.ReadLine(); // Konsol penceresinin açık kalması için

            string date = "2025-10-10";
            // string türünde bir tarih tanımladık
            DateTime tarih = DateTime.Parse(date); // string türünden DateTime türüne parse metodu ile dönüşüm yapıldı
            Console.WriteLine($"Tarih: {tarih}"); // Çıktı: 10.10.2025 00:00:00
            Console.WriteLine(
                $"Tarih: {tarih.GetType()}"); // Çıktı: System.DateTime
            Console.WriteLine(
                    $"Tarih: {tarih.GetType().Name}"); // Çıktı: DateTime
            string date2 = "2025-10-09";
            DateTime tarih2 = Convert.ToDateTime(date2); // Convert sınıfı ile dönüşüm yapıldı
            Console.WriteLine(tarih2);


        }
    }
}
