using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar Geriye Değer Döndermeyen 
            //()
            //Geriye Değer Döndürmeyen Metotlar 
            //Customer -- Listele, Ekle, Sil, Güncelle
            //Void Metotlar

            //void customerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Yıldız");
            //    Console.WriteLine("Merve Çılmaz Yıldız");
            //}

            //customerList(); // Metot Çağırma
            //customerList(); // Metot Çağırma
            //customerList(); // Metot Çağırma
            //customerList(); // Metot Çağırma

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();


            #endregion

            #region Geriye Değer Döndermeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri:... "+ name+ " "+surName);

            //}
            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşe", "Kaya");

            #endregion

            #region Geriye Değer Döndermeyen İnt Parametreli Metotlar

            //void Sum(int number1,int number2,int number3)
            //{
            //    int result=number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(1, 2, 3);
            #endregion

            #region Geriye Değer Döndüren Metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();


            //string StundentCard()
            //{
            //    string name = "Buse";
            //    string surname = "Yıldız";
            //   return name+"  " + surname;
            //}
            //Console.WriteLine(StundentCard());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor )
            //{
            //    string cardInfo= "Ülke: " +countryName + " Ülkesinin Başkenti: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz..: ");
            //x = Console.ReadLine();
            //Console.Write("Başkenti Giriniz: ");
            //y=Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));
            #endregion

            #region Geriye Değer Döndüren İnt Parametreli Metotlar
            //int Sum(int number1,int number2)
            //{
            //    int result= number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(Sum(45,98));
            //Console.WriteLine(Sum(36,58));
            //Console.WriteLine(Sum(435,982));
            //Console.WriteLine(Sum(4353,9182));

            //int examAvg(int exam1,int exam2,int exam3)
            //{
            //    int totalAvg=(exam1+exam2+exam3) / 3;
            //    return totalAvg;
            //}
            //int[] exams = new int[3];
            //for (int i=0;i < exams.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. Sınav Notunu Giriniz: ");
            //    exams[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Öğrenci Ortalaması: "+ examAvg(exams[0], exams[1], exams[2]));

                  
            #endregion
            Console.Read();
        }
    }
}
