using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DataProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net Bu yapının ismidir. Ado.net Bizim c# progralama dilinde sql yapılarını kullanmamıza yarayan çerçevedir


            Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("--------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RQUP3NI\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From TblCategory", connection); // Sorgumuzu yazdığımız yerdir 
            SqlDataAdapter adapter = new SqlDataAdapter(command); // Sorgumuzu çalıştıran ve veriyi getiren yerdir
            DataTable dataTable= new DataTable(tableNumber); // DataTable, verileri tutan bir yapıdır.
            adapter.Fill(dataTable);
            // DataTable'dan verileri çekip ekrana yazdırma
            connection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
         
            Console.Read();
        }
    }
}
