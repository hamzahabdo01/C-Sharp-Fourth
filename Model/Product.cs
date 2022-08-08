using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Fourth.Model
{
    class Product
    {
        static List<Product> products = new List<Product>();
        public int Number { get; set; }
        public string Object_Name { get; set; }
        public int Inventory_Number { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public DateTime dateTime { get; set; }
        public bool isAvailable { get; set; }
        public void Save()
        {
            products.Add(this);
            MessageBox.Show($"{Object_Name} added");

        }
        public static List<Product> GetAllProducts()
        {
            return products;
        }
        public static Product findOne(string name)
        {
            return products.Find(p => p.Object_Name == name);
        }
        public static List<Product> findbyCategory(string name)
        {
            return products.FindAll(p => p.Object_Name == name);
        }



    }
}
