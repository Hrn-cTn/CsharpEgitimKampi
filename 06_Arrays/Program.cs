using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara,istanbul,bursa
            //DeğişkenTürü [] DiziAdı=new DeğişkenTürü[ElemanSayısı];


            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Mavi";
            //colors[3] = "Turuncu";

            //Console.WriteLine(colors[2]);

            //string[] cities= new string[5];
            //  cities[0] = "Milamo";
            //  cities[1] = "Budapest";
            //  cities[2] = "Ankara";
            //  cities[3] = "İstanbul";
            //  cities[4] = "Bursa";
            //  Console.WriteLine(cities[2]); //Ankara

            //int[]numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 46;

            //numbers[4] = 42;
            //numbers[5] = 40;

            //numbers[8] = 34;
            //numbers[9] = 32;

            //Console.WriteLine(numbers[3]);

            //string[] cities = {"Prag","Roma", "Paris", "Berlin", "Madrid", "Budapest", "Ankara", "İstanbul", "Bursa", "Milano" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[]colors= { "Kırmızı", "Sarı", "Mavi", "Turuncu", "Beyaz" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 4, 85, 74, 4567, 56, 324, 566, 234, 255 };
            //for(int i=0;i<numbers.Length;i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //Dizideki En Büyül Elemanı Bulan Program
            //int[] numbers = { 10, 12, 44, 55, 66};
            //int maxnumber = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxnumber)
            //    {
            //        maxnumber = numbers[i];
            //    }

            //}
            //Console.WriteLine(maxnumber);
            #endregion

            #region Dizi Metotları

            //string[]persons= {"ali","ahmet"};
            //Console.WriteLine(persons.Length); //Length dizinin eleman sayısını verir.

            //int[]numbers = { 10, 33,80,12, 44, 55, 66 };
            //Array.Sort(numbers); //Diziyi sıralar
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 10, 33, 80, 12, 44, 55, 66 };
            //Array.Reverse(numbers);
            ////Dizinin elemanlarını ters çevirir
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //string[] persons = { "Ali", "Ahmet", "Mehmet", "Ayşe", "Fatma" };
            //int index=Array.IndexOf(persons, "Mehmet");// Dizideki elemanın indeksini bulur 
            //Console.WriteLine(index);

            //int[] numbers = { 10, 33, 80, 12, 44, 55, 66 };
            // Console.WriteLine("Dizini En Büyük Elemanı: "+numbers.Max()+"Dizin En Küçük Elemanı: "+numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma
            //string[]cities=new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------");
            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}. Şehir: {cities[i]}");
            //}
            #endregion
            Console.Read();

        }
    }
}
