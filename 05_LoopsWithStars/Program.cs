using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane Yıldız Oluşturma

            //for(int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion
            #region Yan Yana 10 Tane Yıldız Oluşturma
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("***********");
            //}

            #endregion
            #region Diküçgen ve Ters Diküçgen Yıldız Oluşturma
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int a=5;a>=1;a--)
            //{
            //    for (int b = 1; b <= a; b++)
            //    {
            //    Console.Write("*");
            //  }
            //   Console.WriteLine();
            //}



            #endregion
            #region Baklava Dilimi
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion

            Console.Read();

        }
    }
}
