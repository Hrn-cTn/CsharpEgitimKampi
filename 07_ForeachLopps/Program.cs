using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLopps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü
            //1:Değişken Türü
            //2:Değişken Adı
            //3:In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Bursa", "Adana" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 1, 45, 78, 23, 4235, 645645, 777 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 1, 45, 78, 23, 4235, 645645, 777 };
            //foreach(int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number + " Çifttir");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number + " Tektir");
            //    }
            //}

            //int[] numbers = { 1, 45, 78, 23, 4235, 645645, 777 };
            //int total = 0;
            //foreach(int number in numbers)
            //{
            //    total += number;
            //}
            //Console.WriteLine("total");

            #endregion
            #region Listeler 
            //Listeler genellikle veri tabanından gelen verileri tutmak için kullanılır.
            //Listeler diziler gibidir.

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Harun ÇETİN";
            //foreach (char c in word)
            //{ Console.WriteLine(c); }
            #endregion
            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması*****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki Öğrenci Sayısını Kullanıcıdan alma
            Console.WriteLine("--------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var:  ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");

            //Öğrenci İsimlerini ve Ortalamalarını Saklayacak Diziler
            string[]studentnames=new string[studentCount]; //Sınıfta kaç öğrenci varsa o kadar isim tutacak bir dizi tanımladık.
            double[]studentExamAvg=new double[studentCount]; //Sınıfta kaç öğrenci varsa o kadar ortalama tutacak bir dizi tanımladık.

            for(int i=0;i<studentCount;i++)
            {
                Console.Write($"{i + 1}. Öğrencinin Adını ve Soyadını Giriniz.:");
                studentnames[i]=Console.ReadLine(); //Kullanıcıdan öğrenci isimlerini alıyoruz.

                double totalExamResult = 0;

                //Öğrencinin 3 adet sınav notunu alıyoruz.
                for(int j=0; j < 3; j++)
                {
                    Console.Write($"{i + 1}. Öğrencinin {j + 1}. Sınav Notunu Giriniz.:");
                    double examResult = double.Parse(Console.ReadLine());
                    totalExamResult += examResult; //Sınav notlarını topluyoruz.
                }
                Console.WriteLine();
                studentExamAvg[i]= totalExamResult / 3; //Öğrencinin ortalamasını hesaplıyoruz.
            }
            //Öğrencilerin Ortalamaları ve Geçip Kalma Durumları 
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"{studentnames[i]}   adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                if (studentExamAvg[i] >= 60)
                {
                    Console.WriteLine($"{studentnames[i]} adlı öğrenci sınavı geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentnames[i]} adlı öğrenci sınavı kaldı.");
                }
                Console.WriteLine("----------------------------------------");
            }

            #endregion
            Console.Read();
        }
    }
}
