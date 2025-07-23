using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dobule Değişkenler
            //double number;
            //number = 4.5;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi*****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice,potatoPrice,tomatoPrice;
            //applePrice = 15.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("----Elma Birim Fiyatı :"+applePrice+" TL");
            //Console.WriteLine("----Portakal Birim Fiyatı :"+ orangePrice + " TL");
            //Console.WriteLine("----Çilek Birim Fiyatı :"+ strawberryPrice + " TL");
            //Console.WriteLine("----Patates Birim Fiyatı :"+ potatoPrice + " TL");
            //Console.WriteLine("----Domates Birim Fiyatı :"+ tomatoPrice + " TL");

            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;

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

            //Console.WriteLine("Alınan Ürün: Elma  - "+" Birim Fiyat: "+appleTotalPrice+ "-  Gramajı : "+ appleGram + " - Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal  - "+" Birim Fiyat: "+ orangeTotalPrice + "-  Gramajı : "+ orangeGram + " - Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek  - "+" Birim Fiyat: "+ strawberryTotalPrice + "-  Gramajı : "+ strawberryGram + " - Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates  - "+" Birim Fiyat: "+ potatoTotalPrice + "-  Gramajı : "+ potatoGram + " - Toplam Tutar: "+potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates  - "+" Birim Fiyat: "+ tomatoTotalPrice + "-  Gramajı : "+ tomatoGram + " - Toplam Tutar:  "+tomatoTotalPrice);

            //double shoppingTotalPriice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+tomatoTotalPrice+potatoTotalPrice;
            //Console.WriteLine("Toplam Tutar : "+shoppingTotalPriice+" TL");

            #endregion

            #region Char Değişkenler
            //char symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentitNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName=Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname=Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentitNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Yolcu : "+passengerName+" "+passengerSurname+ " "+ passengerDistrict + " "+passengerCity+ " "+ passengerAge+" "+passengerIdentitNumber);



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCounter, computerCounter, chairCounter, tvCounter;

            //Console.Write(" Lütfen Aldığınız ayakkabı sayısını giriniz: ");
            //shoeCounter = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız Bilgisayar Sayısını Giriniz: ");
            //computerCounter = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız Sandalye Sayısını Giriniz: ");
            //chairCounter = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldıgınız TV Sayısını Giriniz: ");
            //tvCounter = int.Parse(Console.ReadLine());

            //int totalPrice=shoeCounter*shoePrice+ computerCounter*computerPrice+ chairCounter*chairPrice+tvPrice*tvCounter;
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar : "+totalPrice);
            #endregion

            #region Klavyeden Ondaklıklı Sayı İşlemleri
            double exam1, exam2,exam3,result;

            Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            exam1=double.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

           result=(exam1+exam2 + exam3)/3;
           Console.WriteLine();
           Console.Write("Sınav Ortalamanız: " + result);



            #endregion
            Console.Read();
        }
    }
}
