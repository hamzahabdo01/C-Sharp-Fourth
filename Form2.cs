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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form login = new Form();
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username == "admin" && password == "admin")
            {
                Form1 screen = new Form1(/*string username*/);
                screen.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }
    }
}
