using C_Sharp_Fourth.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace C_Sharp_Fourth
{
    public partial class AddProduct : Form
    {
        LoginPage loginPage;
        public AddProduct(LoginPage Login)
        {
            loginPage = Login;
            InitializeComponent();
            user.Text = loginPage.username;
        }
        Product product;
        private void buttonadd_Click(object sender, EventArgs e)
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
                errorProvider1.Clear();
                product = new Product()
                {
                    Number = txt_number.Text,
                    ObjectName = txt_ObjectName.Text,
                    Count = txt_count.Text,
                    Price = txt_price.Text,
                    Inventory_Num = txt_inventory.Text,
                    Date = dateTimePicker1.Text,
                    isAvailable = checkBox1.Checked

                };
                if (radioButton1.Checked)
                {
                    product.Payment = radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    product.Payment = radioButton2.Text;
                }
                string items = " ";
                foreach (var item in Item.CheckedItems)
                {
                    items += item.ToString();
                }
                MessageBox.Show("Items are:\n" + items);
                product.save();
                Clear();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Product.GetAllProducts();
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
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

        private void Sinventbut_Click(object sender, EventArgs e)
        {
            var item = Product.SearchByInventoryNumber(txt_search.Text);
            if (item != null)
            {
                MessageBox.Show("Inventory Number Found");
            }
            else
            {
                MessageBox.Show("Inventory Number Not Found");
            }
        }

        private void Snamebut_Click(object sender, EventArgs e)
        {
            var item = Product.SearchAllByName(txt_search.Text);
            if (item != null)
            {
                string all = "";
                foreach (Product n in item)
                {
                    all += n.ObjectName + "\n";
                }
                MessageBox.Show(all);
            }
            else
            {
                MessageBox.Show("List Not Found");
            }


        }
    }
}
