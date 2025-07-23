using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //for(x;y;z) 
            //x=başlangıç değeri
            //y=koşul=bitiş değeri
            //z=artış-azalış değeri

            //for (int i = 1; i <=5; i++)
            //{
            //    Console.WriteLine("For Döngüsü: " + i);
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalvalue = 0;
            //for (int i = 1; i <= 10; i++)
            //{ 
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);


            //int totalvalue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //    }
            //}

            //Console.WriteLine(totalvalue);

            #endregion

            #region  While Döngüsü
            //while (şart)
            //{
            //işlemler
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0) {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız:
            int number;
            Console.Write("Lütfen 3 Basamaklı Bir Sayı Giriniz..:");
            number = int.Parse(Console.ReadLine());
            int birler = number % 10;
            int onlar = (number / 10) % 10;
            int yuzler = (number / 100) % 10;
            int toplam = birler + onlar + yuzler;
            Console.WriteLine("Basamaklar Toplamı: " + toplam);
            #endregion
            Console.Read();

        }
    }
}
