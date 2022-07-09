using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Sharp_Fourth.Model;

namespace C_Sharp_Fourth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Number = int.Parse(txt_number.Text),
                Object_Name = txt_ObjectName.Text,
                Inventory_Number = int.Parse(txt_inventory.Text),
                Count = int.Parse(txt_count.Text),
                Price = Double.Parse(txt_price.Text),
                dateTime = dt_Registered_Date.Value,
            };
            product.Save();
            Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Clear()
        {
            txt_count.Text = " ";
            txt_inventory.Text = " ";
            txt_number.Text = " ";
            txt_ObjectName.Text = " ";
            txt_price.Text = " ";
        }
    }
}
