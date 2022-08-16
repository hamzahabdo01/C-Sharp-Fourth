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
    public partial class UserControl1 : UserControl
    {
        private string _PDes;

        public string PDes
        {
            set { _PDes = value; label7.Text = value; }
            get { return _PDes; }
        }
        private string _PTitle;
        public string PTitle
        {
            set { _PTitle = value; label8.Text = value; }
            get { return _PTitle; }
        }
        private string _PPrice;
        public string PPrice
        {
            set { _PPrice = value; label9.Text = value ; }
            get { return _PPrice; }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
