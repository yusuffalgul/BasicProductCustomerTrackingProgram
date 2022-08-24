using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProductTrackingProgram
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=ProductStock;Integrated Security=True");



        private void loginButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Login WHERE Username = @p1 AND Password = @p2",connect);
            command.Parameters.AddWithValue("@p1", usernameTxt.Text);
            command.Parameters.AddWithValue("@p2", passwordTxt.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
