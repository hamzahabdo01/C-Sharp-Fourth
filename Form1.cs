using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_Sharp_Fourth.Model;

namespace C_Sharp_Fourth
{
    public partial class Form1 : Form
    {
        public Form1(/*string username*/)
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Regex NumberCheck = new Regex(@"^[0-9]{3}-[0-9]{3}-[0-9]{4}$");
            Regex InventoryCheck = new Regex(@"^[0-9]{3}-[0-9]{3}$");
            if (string.IsNullOrEmpty(txt_count.Text) || string.IsNullOrEmpty(txt_price.Text) || string.IsNullOrEmpty(txt_inventory.Text) || string.IsNullOrEmpty(txt_ObjectName.Text) || string.IsNullOrEmpty(txt_number.Text))
            {
                if (!NumberCheck.IsMatch(txt_number.Text))
                {
                    errorProvider1.SetError(txt_number, "Wrong format,should be in form of (***-***-****)");
                }
                else
                {
                    errorProvider1.SetError(txt_number, "");
                }
                if (!InventoryCheck.IsMatch(txt_inventory.Text))
                {
                    errorProvider1.SetError(txt_inventory, "Wrong format,,should be in form of (***-***)");
                }
                else
                {
                    errorProvider1.SetError(txt_inventory, "");
                }
                if (string.IsNullOrEmpty(txt_count.Text))
                {
                    errorProvider1.SetError(txt_count, "Count is required");
                }
                else
                {
                    errorProvider1.SetError(txt_count, "");
                }
                if (string.IsNullOrEmpty(txt_price.Text))
                {
                    errorProvider1.SetError(txt_price, "Price is required");
                }
                else
                {
                    errorProvider1.SetError(txt_price, "");
                }
                if (string.IsNullOrEmpty(txt_ObjectName.Text))
                {
                    errorProvider1.SetError(txt_ObjectName, "Count is required");
                }
                else
                {
                    errorProvider1.SetError(txt_ObjectName, "");
                }


            }
            else
            {
                Product product = new Product
                {
                    Number = int.Parse(txt_number.Text),
                    Object_Name = txt_ObjectName.Text,
                    Inventory_Number = int.Parse(txt_inventory.Text),
                    Count = int.Parse(txt_count.Text),
                    Price = Double.Parse(txt_price.Text),
                    dateTime = dt_Registered_Date.Value,
                    isAvailable = checkisAvailable.Checked,
                };
                string items = "";
                foreach (var Item in Item.CheckedItems)
                {
                    items += Item.ToString();
                }
                MessageBox.Show(items);
                product.Save();
                Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product.GetAllProducts();
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 screen = new Form2();
            screen.Show();
        }
        public void Clear()
        {
            txt_count.Text = " ";
            txt_inventory.Text = " ";
            txt_number.Text = " ";
            txt_ObjectName.Text = " ";
            txt_price.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var item = Product.findOne(textBox1.Text);
            if(item != null)
            {
                MessageBox.Show("Object Name Found");
            }
            else
            {
                MessageBox.Show("Object Name Not Found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = Product.findbyCategory(textBox1.Text);
            if (item != null)
            {
                MessageBox.Show("List Found");
            }
            else
            {
                MessageBox.Show("List Not Found");
            }

        }
    }
}
