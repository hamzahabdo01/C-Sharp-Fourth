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
    public partial class DetailPage : Form
    {
        public DetailPage()
        {
            InitializeComponent();
        }
        private String _Num;

        public String Num
        {
            get { return _Num; }
            set { _Num = value; label7.Text = Num; }
        }
        private String _INum;

        public String INum
        {
            get { return _INum; }
            set { _INum = value; label8.Text = INum; }
        }
        private String _Price;

        public String Price
        {
            get { return _Price; }
            set { _Price = value; label9.Text = Price; }
        }
        private String _Count;

        public String Count
        {
            get { return _Count; }
            set { _Count = value; label10.Text = Count; }
        }
        private String _Obj;

        public String Obj
        {
            get { return _Obj; }
            set { _Obj = value; label11.Text = Obj; }
        }
        private String _Date;

        public String Date
        {
            get { return _Date; }
            set { _Date = value; label12.Text = Date; }
        }


    }
}
