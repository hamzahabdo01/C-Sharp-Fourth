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
    public partial class MainContainer : Form
    {
        LoginPage loginPage;
        public MainContainer(LoginPage loginPage)
        {
            InitializeComponent();
            this.loginPage = loginPage;
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            AddProduct form = new AddProduct(loginPage);
            form.MdiParent = this;
            form.Show();
        }

        private void showProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            ViewProductCard view = new ViewProductCard();
            view.MdiParent = this;
            view.Show();
        }

        private void showListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            ToDoList view = new ToDoList();
            view.MdiParent = this;
            view.Show();
        }
    }
}
