using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Fourth.Model
{
    internal class Product
    {
        private static List<Product> Products = new List<Product>();
        public string Number { get; set; }
        public string Date { get; set; }
        public string Inventory_Num { get; set; }
        public string ObjectName { get; set; }
        public string Price { get; set; }
        public string Count { get; set; }
        public bool isAvailable { get; set; }
        public string Payment { get; set; } //for group box


        public void save()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source =7AMOOZ;Initial Catalog=product;Integrated Security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"Insert into ProductTB values({this.Number},'{this.Inventory_Num}',{this.Price},'{this.ObjectName}',{this.Count},{this.Date},{this.isAvailable})", con);
                cmd.ExecuteReader();
            }
            catch(Exception ex)
            {
                MessageBox.Show("1"+ex.Message);
            }
            
        }
        public static List<Product> GetAllProducts()
        {
            List<Product> temp = new List<Product>();
            try
            {

                SqlConnection con = new SqlConnection("Data Source =7AMOOZ;Initial Catalog=product;Integrated Security=true;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"Select * from ProductTB", con);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    temp.Add(new Product()
                    {
                        Number = (string)result["Num"],
                        Date = (string)result["Date"],
                        Inventory_Num = (string)result["InvNum"],
                        ObjectName = (string)result["ObjectName"],
                        Price = (string)result["Price"],
                        Count = (string)result["Count"],
                        isAvailable = (bool)result["isAvailable"]
                    }
                    );
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return temp;
        }
        public static List<Product> SearchAllByName(string name)
        {
            return GetAllProducts().FindAll(item => item.ObjectName == name);
        }
        public static Product SearchByInventoryNumber(string invent)
        {
            return GetAllProducts().Find(x => x.Inventory_Num == invent);
        }
    }
}
