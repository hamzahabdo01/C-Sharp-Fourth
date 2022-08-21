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
    public partial class ProductCard : UserControl
    {
        private string _title;


        public string Title
        {
            get { return _title; }
            set { _title = value; label1.Text = Title; }
        }
        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; label3.Text = Price; }
        }
        private string _desc;

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; label2.Text = Desc; }
        }
        public ProductCard()
        {
            InitializeComponent();
        }
    }
}
