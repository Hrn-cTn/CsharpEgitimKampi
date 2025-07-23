using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else
            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if(password=="abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Lütfen Başkenti Giriniz: ");
            //capital=Console.ReadLine();
            //Console.WriteLine("Lütfen ülke Giriniz:");
            //country=Console.ReadLine();

            //if(capital=="ankara"& country=="türkiye")
            //{
            //    Console.WriteLine("veriler doğrulandı");
            //}
            //else
            //{ Console.WriteLine("hatalı bilgi"); }

            //int number;
            //Console.Write("Sayıyı GiriniZ: ");
            //number = int.Parse(Console.ReadLine());
            //if(number==5)
            //{
            //    Console.WriteLine("Sayı 5'e eşit");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result="Hata";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{ result = "Sonuç vasat"; }

            //if (average > 50 & average <= 70)
            //{ result = "Sonuç Orta"; }

            //if (average > 70 & average <= 84)
            //{ result = "Sonuç iyi"; }

            //if (average > 84)
            //{ result = "Sonuç çok iyi"; }

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen Şehir Giriniz: ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "izmir" | city == "istanbul")
            //{
            //    Console.WriteLine("Şehir Türkiye'de Bulunuyor");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Türkiye'de Bulunmuyor");
            //}

            //Console.Write("Lütfen kullanıcı adını giriniz:");
            //string userName=Console.ReadLine();
            //if(userName!="admin")
            //{ Console.WriteLine("bu kullanıcı adı kabul edilemez"); }
            //else { Console.WriteLine("Hoşgeldiniz.!"); }


            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result= number % 5;
            //Console.Write(result);

            //Console.Write("1.Sayıyı Giriniz:");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.Write("{0} sayısının {1} sayısına bölümünden kalan: {2}", number1, number2, result);

            //Console.Write("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if( number%2 == 0 )
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Tektir.");
            //}
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team, result;
            //Console.Write("Lütfen Bir Harf Giriniz: ");
            //result = char.Parse(Console.ReadLine());
            //if(result == 'g' || result == 'G')
            //{
            //    Console.WriteLine("Galatasaray Takımı");
            //}
            //if (result == 'f' || result == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe Takımı");
            //}
            //if (result == 'b' || result == 'B')
            //{
            //    Console.WriteLine("Beşiktaş Takımı");
            //}

            //else
            //{
            //    Console.WriteLine("Geçersiz Harf");
            //}
            #endregion

            #region Örnek Proje Uygulaması
            //Console.WriteLine("**** C# Eğitim Kampı Restoran ****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçeçekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();



            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz Menuyu Seçin...:");
            //menuItem=Console.ReadLine();
            //if (menuItem=="1")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("-------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kuzu tandır");
            //    Console.WriteLine("2-Köri Soslu Tavuk");
            //    Console.WriteLine("3-Kızartma Tabağı");
            //    Console.WriteLine("4-Fasulye Pilav");
            //    Console.WriteLine("5-Fırında Somon");
            //    Console.WriteLine("6-Patlıcan Musakka");
            //    Console.WriteLine("-------------Ana Yemekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("-------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezo Gelin Çorbası");
            //    Console.WriteLine("-------------Çorbalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("-------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita");
            //    Console.WriteLine("-------------Pizzalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("-------------İçeçekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("-------------İçeçekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("-------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("-------------Tatlılar------------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case Yapısı
            //Console.Write("Lütfen Ay Girişi Yapınız..:");
            //int mothNumber=int.Parse(Console.ReadLine());

            //switch (mothNumber)
            //{
            //    case 1:Console.Write("Ocak");break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Geçersiz Ay Girişi"); break;
            //}

            #endregion

            #region Switch Case Hesab Makinesi

            int number1, number2, result;
            char symbol;
            Console.Write("Lütfen 1. Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen 2. Sayıyı Giriniz: ");
            number2=int.Parse(Console.ReadLine());
            Console.Write("Lütfen İşlem Seçiniz (+, -, *, /): ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+'://iki nokta
                    result = number1 + number2;
                    Console.WriteLine("Toplama İşlemi Sonucu: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Çıkarma İşlemi Sonucu: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpma İşlemi Sonucu: "+result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölme İşlemi Sonucu: "+result);
                    break;
                default:
                    Console.WriteLine("Geçersiz İşlem Seçimi");
                    break;


            }


            #endregion
            Console.Read();

        }
    }
}
