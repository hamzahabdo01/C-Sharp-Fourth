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
    public partial class ViewProductCard : Form
    {
        public ViewProductCard()
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

        private void ViewProductCard_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in Product.GetAllProducts())
            {
                ProductCard pc = new ProductCard()
                {
                    Title = item.Inventory_Num,
                    Desc = item.ObjectName,
                    Price = item.Price,

                };
                //     pc.Click += Custom;
                pc.Click += (object o, EventArgs ev) =>
                {
                    DetailPage Dp = new DetailPage()
                    {
                        Num = item.Number,
                        INum = item.Inventory_Num,
                        Obj = item.ObjectName,
                        Date = item.Date,
                        Price = item.Price,
                        Count = item.Count,
                    };
                    Dp.Show();
                    Hide();
                };
                flowLayoutPanel1.Controls.Add(pc);
            }
        }
    }
}
