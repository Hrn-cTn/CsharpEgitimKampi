using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            // Console.Write("Merhaba Dünya");
            //  Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region StringDegiskenler
            //string 
            //Değişkenin_türü değişken_adı;

            //string name;
            //name = "Harun";
            //Console.WriteLine(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: "+customerPhone);
            //Console.WriteLine("Email Adresi: "+customerEmail);
            //Console.WriteLine("Adres: "+district + "/" +city);
            //Console.WriteLine("------------------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname="Kaya";
            //customerPhone = "+90 400 300 20 10";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";

            //Console.WriteLine("------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("------------------------------------------------");

            #endregion

            #region int değişkenler

            //int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyati ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyati : "+hamburgerPrice +"TL");
            Console.WriteLine("----Pizza  : "+pizzaPrice +"TL");
            Console.WriteLine("----Kola : "+cokePrice +"TL");
            Console.WriteLine("----Limonata : "+lemonadePrice +"TL");
            Console.WriteLine("----Kızartma: "+friesPrice +"TL");
            Console.WriteLine("----Su : "+waterPrice +"TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyati ****");


            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totallemondePrice;
            int totalWaterPrice;



            hamburgerCount = 3;
            cokeCount=3;
            waterCount=3;
            friesCount=1;
            pizzaCount=0;
            lemonadeCount=0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalWaterPrice= waterCount * waterPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totallemondePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Hamburger Tutarı :"+totalHamburgerPrice);
            Console.WriteLine("Kola Tutarı: "+totalCokePrice);
            Console.WriteLine("Su Tutarı: "+totalWaterPrice);
            Console.WriteLine("Patates Tutarı: "+totalFriesPrice);
            Console.WriteLine("Pizza Tutarı : "+totalPizzaPrice);
            Console.WriteLine("Limonata Tutarı :"+ totallemondePrice);

            Console.WriteLine();

            int totalPrice=totalCokePrice+totalWaterPrice+totalFriesPrice+totalHamburgerPrice+totallemondePrice+totalPizzaPrice;
            Console.WriteLine("Toplam Tutar : "+totalPrice+" TL");
            #endregion

            Console.Read();
        }
    }
}