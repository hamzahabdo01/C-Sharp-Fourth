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
    public partial class LoginPage : Form
    {
        public string username { get; set; }
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "admin" && txt_Password.Text == "admin")
            {
                Hide();
                username = txt_Username.Text;
                MainContainer mainContainer = new MainContainer(this);
                mainContainer.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            txt_Username.Text = "";
            txt_Password.Text = "";
        }
    }
}
