using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using C_Sharp_Fourth.Model;

namespace C_Sharp_Fourth
{
    public partial class DBConnector : Form
    {
        public DBConnector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = @"Data Source = 7AMOOZ;Initial Catalog = product; Integrated Security = true;";
                SqlConnection co = new SqlConnection(connectionString);
                co.Open();
                MessageBox.Show("DB Connected");
                co.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to connect"+ex.Message);
            }
        }
    }   
}
