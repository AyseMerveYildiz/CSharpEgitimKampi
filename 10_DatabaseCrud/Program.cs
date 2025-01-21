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
            
            //Crud-->//Create - Read - Update - Delete

            Console.WriteLine("*****Menü Sipariş İşlem Paneli*****");
            Console.WriteLine();

            Console.WriteLine("--------------------------------------");

            #region Kategori Ekleme
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=MERMILIUS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Insert Into TblCategory (CategoryName) values (@p1)", connection);
            //cmd.Parameters.AddWithValue("@p1", categoryName);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Kategori başarıyla eklendi!");
            #endregion

            #region Ürün Ekleme
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MERMILIUS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus)values (@productName,@productPrice,@productStatus)", connection);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", true);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Ürün eklemesi başarılı ! ");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=MERMILIUS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable); 
            //foreach (DataRow rows in dataTable.Rows)
            //{
            //  foreach (var items in rows.ItemArray)
            //  {
            //       Console.Write(items.ToString() + " ");
            //   }
            //    Console.WriteLine( );
            //}

            //connection.Close();

            #endregion

            #region Ürün Güncelleme İşlemi  


            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MERMILIUS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Delete from TblProduct where productId=@productId",connection);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme İşlemi Yapıldı");
            #endregion

            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MERMILIUS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand cmd = new SqlCommand("Update TblProduct Set productName=@productName,productPrice=@productPrice where productId=@productId", connection);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("Güncelleme Başarılı!");
            #endregion


            Console.Read();


        }
    }
}
