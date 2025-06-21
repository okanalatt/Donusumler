using System.Threading.Channels;

namespace Donusumler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Dönüşüm Türleri
            ////Implicit Conversion (Örtük Dönüşüm)
            ////Explicit Conversion (Açık Dönüşüm)
            ////Parse ve TryParse Metotları
            ////Convert Sınıfı
            //int sayi = 10; // int türünde bir değişken tanımladık
            //long uzunSayi = sayi; // int türünden long türüne örtük dönüşüm yapıldı (Implicit Conversion)
            //Console.WriteLine($"Örtük Dönüşüm: {uzunSayi}"); // Çıktı: 10
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {sayi}"); // Çıktı: 10
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {sayi.GetType()}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {uzunSayi.GetType()}"); // Çıktı: System.Int64
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {sayi.GetType().Name}"); // Çıktı: Int32
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {uzunSayi.GetType().Name}"); // Çıktı: Int64
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {sayi.GetType().FullName}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {uzunSayi.GetType().FullName}"); // Çıktı: System.Int64
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {sayi.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            //Console.WriteLine(
            //    $"Örtük Dönüşüm: {uzunSayi.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int64, Version=
            //// Açık Dönüşüm (Explicit Conversion)
            //double ondalikSayi = 10.5; // double türünde bir değişken tanımladık
            //int tamSayi = (int)ondalikSayi; // double türünden int türüne açık dönüşüm yapıldı (Explicit Conversion)
            //Console.WriteLine($"Açık Dönüşüm: {tamSayi}"); // Çıktı: 10
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {ondalikSayi}"); // Çıktı: 10.5
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {ondalikSayi.GetType()}"); // Çıktı: System.Double
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {tamSayi.GetType()}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {ondalikSayi.GetType().Name}"); // Çıktı: Double
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {tamSayi.GetType().Name}"); // Çıktı: Int32
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {ondalikSayi.GetType().FullName}"); // Çıktı: System.Double
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {tamSayi.GetType().FullName}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {ondalikSayi.GetType().AssemblyQualifiedName}"); // Çıktı: System.Double, Version=
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {tamSayi.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            //// Parse ve TryParse Metotları
            //string sayiString = "123"; // string türünde bir sayı tanımladık
            //int sayiParse = int.Parse(sayiString); // string türünden int türüne parse metodu ile dönüşüm yapıldı
            //Console.WriteLine($"Parse Metodu: {sayiParse}"); // Çıktı: 123
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiString}"); // Çıktı: 123
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiString.GetType()}"); // Çıktı: System.String
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiParse.GetType()}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiString.GetType().Name}"); // Çıktı: String
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiParse.GetType().Name}"); // Çıktı: Int32
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiString.GetType().FullName}"); // Çıktı: System.String
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiParse.GetType().FullName}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiString.GetType().AssemblyQualifiedName}"); // Çıktı: System.String, Version=
            //Console.WriteLine(
            //    $"Parse Metodu: {sayiParse.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            //// TryParse Metodu
            //string sayiString2 = "456a"; // string türünde bir sayı tanımladık (hatalı)
            //int sayiTryParse;
            //bool basarili = int.TryParse(sayiString2, out sayiTryParse); // TryParse metodu ile dönüşüm yapıldı
                
            //if (basarili)
            //{
            //    Console.WriteLine($"TryParse Metodu Başarılı: {sayiTryParse}"); // Çıktı: 456
            //}
            //else
            //{
            //    Console.WriteLine("TryParse Metodu Başarısız: Hatalı sayı formatı"); // Çıktı: Hatalı sayı formatı
            //}
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiString2}"); // Çıktı: 456a
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiString2.GetType()}"); // Çıktı: System.String
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiTryParse.GetType()}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiString2.GetType().Name}"); // Çıktı: String
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiTryParse.GetType().Name}"); // Çıktı: Int32
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiString2.GetType().FullName}"); // Çıktı: System.String
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiTryParse.GetType().FullName}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiString2.GetType().AssemblyQualifiedName}"); // Çıktı: System.String, Version=
            //Console.WriteLine(
            //    $"TryParse Metodu: {sayiTryParse.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            //// Convert Sınıfı
            //string sayiString3 = "789"; // string türünde bir sayı tanımladık
            //int sayiConvert = Convert.ToInt32(sayiString3); // Convert sınıfı ile dönüşüm yapıldı
            //Console.WriteLine($"Convert Sınıfı: {sayiConvert}"); // Çıktı: 789
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiString3}"); // Çıktı: 789
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiString3.GetType()}"); // Çıktı: System.String
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiConvert.GetType()}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiString3.GetType().Name}"); // Çıktı: String
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiConvert.GetType().Name}"); // Çıktı: Int32
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiString3.GetType().FullName}"); // Çıktı: System.String
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiConvert.GetType().FullName}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiString3.GetType().AssemblyQualifiedName}"); // Çıktı: System.String, Version=
            //Console.WriteLine(
            //    $"Convert Sınıfı: {sayiConvert.GetType().AssemblyQualifiedName}"); // Çıktı: System.Int32, Version=
            //// Convert sınıfı ile dönüşümde hata oluşursa, bir istisna fırlatılır
            
            //try
            //{
            //    string hataliSayiString = "123abc"; // Hatalı bir string tanımladık
            //    int hataliSayiConvert = Convert.ToInt32(hataliSayiString); // Hata oluşacak
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine($"Hata: {ex.Message}"); // Çıktı: Hata: Input string was not in a correct format.
            //}
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine($"Hata: {ex.Message}"); // Çıktı: Hata: Value was either too large or too small for an Int32.
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Beklenmeyen Hata: {ex.Message}"); // Çıktı: Beklenmeyen Hata: ...
            //}

            ////decimal ya da double veri tipiyle bölme işlemi yapıp ekrana yazdırın
            //decimal sayi1 = 10.5m; // decimal türünde bir sayı tanımladık
            //decimal sayi2 = 3.2m; // decimal türünde bir sayı tanımladık
            //decimal bolum = sayi1 / sayi2; // decimal türünde bölme işlemi yapıldı
            //Console.WriteLine($"Decimal Bölme: {bolum}"); // Çıktı: 3.28125
            //Console.Write("Ondalık Sayi gir");
            //double d1=Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan sayı alıyoruz
            //Console.Write("Ondalık Sayi gir");
            //double d2 = Convert.ToDouble(Console.ReadLine()); // Kullanıcıdan sayı alıyoruz
            //double sonuc=d1/d2; // double türünde bölme işlemi yapıldı
            //Console.WriteLine(sonuc);
            //Console.ReadLine(); // Konsol penceresinin açık kalması için

            ////byte veri tipiyle bölme işlemi yapıp ekrana yazdırın
            //byte b1 = 10; // byte türünde bir sayı tanımladık
            //byte b2 = 3; // byte türünde bir sayı tanımladık
            //byte bolumByte = (byte)(b1 / b2); // byte türünde bölme işlemi yapıldı (açık dönüşüm ile)
            //Console.WriteLine("Byte tipli deger gir");
            //byte b3= Convert.ToByte(Console.ReadLine()); // Kullanıcıdan byte türünde sayı alıyoruz
            //byte s = (byte) (b1 / b3);
            //Console.WriteLine(s);
            //Console.WriteLine($"Byte Bölme: {bolumByte}"); // Çıktı: 3
            //Console.WriteLine(
            //    $"Byte Bölme: {b1} / {b2} = {bolumByte}"); // Çıktı: Byte Bölme: 10 / 3 = 3
            //Console.ReadLine(); // Konsol penceresinin açık kalması için

            //string date = "2025-10-10";
            //// string türünde bir tarih tanımladık
            //DateTime tarih = DateTime.Parse(date); // string türünden DateTime türüne parse metodu ile dönüşüm yapıldı
            //Console.WriteLine($"Tarih: {tarih}"); // Çıktı: 10.10.2025 00:00:00
            //Console.WriteLine(
            //    $"Tarih: {tarih.GetType()}"); // Çıktı: System.DateTime
            //Console.WriteLine(
            //        $"Tarih: {tarih.GetType().Name}"); // Çıktı: DateTime
            //string date2 = "2025-10-09";
            //DateTime tarih2 = Convert.ToDateTime(date2); // Convert sınıfı ile dönüşüm yapıldı
            //Console.WriteLine(tarih2);

            ////Cast işlemi bir veriyi başka bir veri tipine donusturme ıslemıdır.
            ////Cast işlemi, verinin türünü değiştirmek için kullanılır.
            ////Örneğin, bir int değerini double'a dönüştürmek için cast işlemi yapılabilir.
            //int intDeger = 42; // int türünde bir değer tanımladık
            //double doubleDeger = (double)intDeger; // int türünden double türüne cast işlemi yapıldı
            //Console.WriteLine($"Cast İşlemi: {doubleDeger}"); // Çıktı: 42.0
            //Console.WriteLine(
            //    $"Cast İşlemi: {intDeger}"); // Çıktı: 42
            //Console.WriteLine(
            //    $"Cast İşlemi: {intDeger.GetType()}"); // Çıktı: System.Int32
            //Console.WriteLine(
            //    $"Cast İşlemi: {doubleDeger.GetType()}"); // Çıktı: System.Double
            //Console.WriteLine(
            //    $"Cast İşlemi: {intDeger.GetType().Name}"); // Çıktı: Int32


            //byte a = 255;
            //int b = a; // byte türünden int türüne örtük dönüşüm yapıldı (Implicit Conversion)
            //Console.WriteLine($"Örtük Dönüşüm: {b}"); // Çıktı: 255

            ////Expicit dönüşüm (Explicit Conversion)
            //double c = 123.456; // double türünde bir değer tanımladık
            //int d = (int)c; // double türünden int türüne açık dönüşüm yapıldı (Explicit Conversion)
            //Console.WriteLine($"Açık Dönüşüm: {d}"); // Çıktı: 123
            //Console.WriteLine(
            //    $"Açık Dönüşüm: {c}"); // Çıktı: 123.456

            //int x = 300;
            //byte y = (byte)x; // int türünden byte türüne açık dönüşüm yapıldı (Explicit Conversion)
            //Console.WriteLine($"Açık Dönüşüm: {y}"); // Çıktı: 44 (300 sayısı byte sınırlarını aştığı için taşma meydana gelir)

            ////Parse : string türünden sayısal bir değeri, ilgili sayısal türüne dönüştürmek için kullanılır.Her tipin kendi içinde parse metodu vardır. Converte gore hızlıdır,
            ////Ama fazla yetenegı yoktur. Sadece string türünden sayısal değerleri parse edebilir.

            //string deger = "15";
            //// string türünde bir sayı tanımladık
            //int sayiParse2 = int.Parse(deger); // string türünden int türüne parse metodu ile dönüşüm yapıldı

            //// 2 sayı alın kullanıcıdan toplayın.
            //Console.Write("1. Sayıyı Giriniz: ");
            //int parse1= int.Parse(Console.ReadLine()); // Kullanıcıdan ilk sayıyı alıyoruz
            //Console.Write("2. Sayıyı Giriniz: ");
            //int parse2 = int.Parse(Console.ReadLine()); // Kullanıcıdan ikinci sayıyı alıyoruz
            //Console.WriteLine($"Toplam: {parse1 + parse2}"); // Toplama işlemi yapılıyor ve ekrana yazdırılıyor
            //Console.WriteLine("Sayi gir :");
            //string sayi22= Console.ReadLine(); // Kullanıcıdan string türünde bir sayı alıyoruz
            //int donusenSayi1 = int.Parse(sayi22);
            //Console.ReadKey();

            //string k = "4.23"; // string türünde bir değer tanımladık
            //string z = "2.12"; // string türünde bir değer tanımladık
            //double bolmeislem = double.Parse(k) / double.Parse(z);
            //Console.WriteLine($"Bölme İşlemi: {bolmeislem}");

            //Console.ReadKey();

            //int ab = 75;
            //double yb = 8.15; // double türünde bir değer tanımladık
            //bool zb = false;// bool türünde bir değer tanımladık

            //string abString = ab.ToString(); // int türünden string türüne dönüşüm yapıldı

            //string ybString = yb.ToString(); // double türünden string türüne dönüşüm yapıldı
            //string zbString = zb.ToString(); // bool türünden string türüne dönüşüm yapıldı

            //int number= Convert.ToInt32("45"); // string türünden int türüne dönüşüm yapıldı
            //Console.WriteLine($"Convert Sınıfı ile Dönüşüm: {number}"); // Çıktı: 45
            //int number1 = Convert.ToInt32(null);
            //int number3=int.Parse("45"); // string türünden int türüne parse metodu ile dönüşüm yapıldı
            //int number4 = int.Parse(null);
            //Console.WriteLine($"Parse Metodu ile Dönüşüm: {number3}"); // Çıktı: 45

            //char a = 'A';   
            //int convertA=Convert.ToChar(a); // char türünden int türüne dönüşüm yapıldı
            //Console.WriteLine($"Convert Sınıfı ile Dönüşüm: {convertA}"); // Çıktı: 65 (ASCII değeri)
            ////ASCII tablosunu araştıralım.
            ////ASCII tablosu, karakterlerin sayısal karşılıklarını gösteren bir tablodur.
            ////Örneğin, 'A' karakterinin ASCII değeri 65'tir. Bu nedenle, Convert.ToChar(a) işlemi 65 değerini döndürür.
            ////ASCII tablosunda 0-127 arasındaki karakterler bulunur. Bu karakterler, İngilizce alfabesindeki harfler, rakamlar ve bazı özel karakterleri içerir.
            ////Örneğin, 'A' karakteri 65, 'B' karakteri 66, 'C' karakteri 67 gibi devam eder.
            ////ASCII tablosu, bilgisayarların karakterleri sayısal olarak temsil etmesini sağlar. Bu sayede, karakterler üzerinde matematiksel işlemler yapılabilir.
            ////Örneğin, 'A' karakterinin ASCII değeri 65 olduğu için, Convert.ToChar(65) işlemi 'A' karakterini döndürür.
            //Console.WriteLine($"Convert Sınıfı ile Dönüşüm: {Convert.ToChar(65)}"); // Çıktı: A
            ////Console.WriteLine($"Convert Sınıfı ile Dönüşüm: {Convert.ToChar(66)}"); // Çıktı: B
            ////Console.WriteLine($"Convert Sınıfı ile Dönüşüm: {Convert.ToChar(67)}"); // Çıktı: C
            ////Console.WriteLine($"Convert Sınıfı ile Dönüşüm: {Convert.ToChar(68)}"); // Çıktı: D

            DateTime dta=DateTime.Now; // Şu anki tarihi ve saati alıyoruz
            Console.WriteLine(dta.ToString("dd/MM/yyyy"));
            Console.WriteLine(dta.ToString("yyyy-MM-dd"));
            Console.WriteLine(dta.ToString("dddd,MMM dd"));
            Console.WriteLine(dta.ToString("dd MMMMM dddd"));
            Console.ReadLine(); // Konsol penceresinin açık kalması için

            double money = 1356.15;
            Console.WriteLine(money.ToString("C"));
            Console.WriteLine(money.ToString("F2"));

            Console.ReadLine(); // Konsol penceresinin açık kalması için

        }
    }
}
