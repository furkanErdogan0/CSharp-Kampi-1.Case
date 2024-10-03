using System;
using System.Runtime.InteropServices;
using System.Text;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region UTF-8 kullanımı

            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("₺");

            #endregion

            #region DoubleDeğişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı : " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı : " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı : " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı : " + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma -  \t Birim Fiyat: " + applePrice + "\t Gramaj: " + appleGram + "\t - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal -  Birim Fiyat: " + orangePrice + "\t Gramaj: " + orangeGram + "\t - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - \t Birim Fiyat: " + strawberryPrice + "\t Gramaj: " + strawberryGram + "\t - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - \t Birim Fiyat: " + potatoPrice + "\t Gramaj: " + potatoGram + "\t - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - \t Birim Fiyat: " + tomatoPrice + "\t Gramaj: " + tomatoGram + "\t - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region CharDeğişkenler

            //Sezar şifreleme = harfin alfabedeki sırasından 3 sonraki harf ile değiştirme örn : ABC = DEF 
            //sezar şifreleme yapacaksak bir cümledeki her harfi ayrı almalıyız bu yüzden char veri tipi gereklidir. '' ile tanımlanır.

            //char symbol;

            //symbol = 'a';

            //Console.WriteLine(symbol);




            #endregion

            #region Klavyeden Veri Girişleri StringDeğişkenler

            //Console.WriteLine("**** CSharp Havayolları  Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, 
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + "  - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " +
            //    passengerDistrict + "/" + passengerCity + " " + passengerAge);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            ////Console.ReadLine(); ile aldığımız ifade string olarak gelir. Bu yüzden parse yapıyoruz int e çeviriyoruz.

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: " + result);

            ////console'dan veri girerken '.' yerine ',' ile girmeliyiz - burada girdiğimiz nokta console'da virgül olarak geçer.

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);




            #endregion



            Console.Read();
        }
    }
}
