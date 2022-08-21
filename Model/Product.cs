using System;
using System.Collections.Generic;
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
            Products.Add(this);
            MessageBox.Show($"{ObjectName} added successfully");
        }
        public static List<Product> GetAllProducts()
        {
            return Products;

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
