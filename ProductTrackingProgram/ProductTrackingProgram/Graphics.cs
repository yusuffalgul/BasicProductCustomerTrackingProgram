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
    public partial class Graphics : Form
    {
        public Graphics()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=ProductStock;Integrated Security=True");


        private void Graphics_Load(object sender, EventArgs e)
        {
            //Graphic1-Products
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT Product,Count(*) as 'Number' FROM ProductStock GROUP BY Product ORDER BY Number", connect);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                productChart.Series["Products"].Points.AddXY(dr[0], dr[1]);
            }
            connect.Close();

            //Graphic2-Categories
            connect.Open();
            SqlCommand command2 = new SqlCommand("SELECT Category,Count(*) as 'Number' FROM ProductStock GROUP BY Category ORDER BY Number", connect);
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                categoryChart.Series["Categories"].Points.AddXY(dr2[0], dr2[1]);
            }
            connect.Close ();

            
            //Graphic3-Brand
            connect.Open();
            SqlCommand command3 = new SqlCommand("SELECT Brand,Count(*) as 'Number' FROM ProductStock GROUP BY Brand ORDER BY Number", connect);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                brandChart.Series["Brands"].Points.AddXY(dr3[0], dr3[1]);
            }
            connect.Close();

            //Graphic3-ProductPriceAverage
            connect.Open();
            SqlCommand command4 = new SqlCommand("SELECT Product,AVG(PRİCE) FROM ProductStock GROUP BY Product", connect);
            SqlDataReader dr4 = command4.ExecuteReader();
            while (dr4.Read())
            {
                productPriceChart.Series["Product-Price"].Points.AddXY(dr4[0], dr4[1]);
            }
            connect.Close();






        }

        private void backButtonGr_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage(); 
            mainPage.Show();
            this.Hide();
        }

        private void productChart_Click(object sender, EventArgs e)
        {

        }
    }
}
