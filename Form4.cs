using C_Sharp_Fourth.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Fourth
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            panel3.Top = 67;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel3.Top = 135;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>{};
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in products)
            {
                UserControl1 p = new UserControl1();
                p.PTitle = item.Object_Name;
                p.PDes = item.Object_Name; 
                p.PPrice = item.Price.ToString();
                flowLayoutPanel1.Controls.Add(p);
            }
        }
    }
}
