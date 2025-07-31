using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create--Read--Update--Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("------------------------");
            #region Kategori Ekleme İşlemi


            //Console.Write("Eklemek İstediğiniz Kategori Adını Giriniz: ");

            //string categoryName = Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RQUP3NI\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery(); // Sorguyu çalıştırır ve etkilenen satır sayısını döner.
            //connection.Close();

            //Console.Write("Kategori Başarıyla Kayıt Edildi.");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RQUP3NI\\SQLEXPRESS;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);//Eşleştirme yapıyoruz.
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün Eklemesi Başarılı");
            #endregion

            #region Ürün Listeme İşlemi 
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RQUP3NI\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command=new SqlCommand("Select * From TblProduct", connection); // Sorgumuzu yazdığımız yerdir
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //// Sorgumuzu çalıştıran ve veriyi getiren yerdir
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable); // DataTable'a veriyi dolduruyoruz
            //// DataTable'dan veriyi alıp listeye ekliyoruz
            //foreach (DataRow row in dataTable.Rows)
            //{ //Önce Satıra gidiyor Sonra satırdaki sutüunları yazıyor.
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silmek istediğiniz ürünün Id'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RQUP3NI\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery(); // Sorguyu çalıştırır ve etkilenen satır sayısını döner.
            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı.!");
            #endregion

            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellemek istediğiniz ürünün Id'sini giriniz: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName=Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection ("Data Source=DESKTOP-RQUP3NI\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command=new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme Başarılı.!");
            #endregion
            Console.Read();

        }
    }
}
