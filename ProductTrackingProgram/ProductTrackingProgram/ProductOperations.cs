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
    public partial class ProductOperations : Form
    {
        public ProductOperations()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=ProductStock;Integrated Security=True");


        private void ProductOperations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productStockDataSet2.ProductStock' table. You can move, or remove it, as needed.
            this.productStockTableAdapter1.Fill(this.productStockDataSet2.ProductStock);


        }


        private void addProductButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("INSERT into ProductStock (Product,Stock,Brand,Price,Category) values (@p1,@p2,@p3,@p4,@p5)", connect);
            command.Parameters.AddWithValue("@p1", productAddTxt.Text);
            command.Parameters.AddWithValue("@p2", stockAddTxt.Text);
            command.Parameters.AddWithValue("@p3", brandAddTxt.Text);
            command.Parameters.AddWithValue("@p4", priceAddTxt.Text);
            command.Parameters.AddWithValue("@p5", categoryAddTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Product Added");

        }
      
        private void selectProductButton_Click(object sender, EventArgs e)
        {
            //this.productStockTableAdapter.Fill(this.productStockDataSet.ProductStock);
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM ProductStock", connect);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            MessageBox.Show("Found");
        }

        private void updateStockButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("UPDATE ProductStock SET Stock = @p1 WHERE Product = @p2", connect);
            command.Parameters.AddWithValue("@p1", updateStockTxt.Text);
            command.Parameters.AddWithValue("@p2", updateProductTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Product Stock Updated");
        }

        private void updatePriceButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("Update ProductStock SET Price = @p1 Where Product = @p2", connect);
            command.Parameters.AddWithValue("@p1", updatePriceTxt.Text);
            command.Parameters.AddWithValue("@p2", updateProductTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Product Price Updated");
        }

        private void clearProductButton_Click(object sender, EventArgs e)
        {
            productAddTxt.Text = "";
            stockAddTxt.Text = "";
            brandAddTxt.Text = "";
            priceAddTxt.Text = "";
            updatePriceTxt.Text = "";
            updateStockTxt.Text = "";
            updateProductTxt.Text = "";
            deleteBrandTxt.Text = "";
            deleteProductTxt.Text = "";
            sellBrandTxt.Text = "";
            sellProductTxt.Text = "";
            soldNumberTxt.Text = "";
            buyBrandTxt.Text = "";
            buyProductTxt.Text = "";
            boughtNumberTxt.Text = "";
            selectProductTxt.Text = "";
            categoryAddTxt.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("DELETE FROM ProductStock WHERE Product = @p1 and Brand = @p2", connect);
            command.Parameters.AddWithValue("@p1", deleteProductTxt.Text);
            command.Parameters.AddWithValue("@p2", deleteBrandTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Product Deleted");
        }

        private void backMainButton_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void soldButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("UPDATE ProductStock SET Stock = Stock - @p1  WHERE Product = @p2 AND Brand = @p3", connect);
            command.Parameters.AddWithValue("@p1",soldNumberTxt.Text);
            command.Parameters.AddWithValue("@p2",sellProductTxt.Text);
            command.Parameters.AddWithValue("@p3", sellBrandTxt.Text);
            command.ExecuteNonQuery();
            connect.Close ();
            MessageBox.Show("Stock Updated");
        }

        private void boughtButton_Click(object sender, EventArgs e)
        {
            connect.Open ();
            SqlCommand command = new SqlCommand("UPDATE ProductStock SET Stock = Stock + @p1 WHERE Product = @p2 AND Brand = @p3", connect);
            command.Parameters.AddWithValue("@p1", boughtNumberTxt.Text);
            command.Parameters.AddWithValue("@p2", buyProductTxt.Text);
            command.Parameters.AddWithValue("@p3", buyBrandTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Stock Updated");
        }


        private void selectProductBtn_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM ProductStock WHERE Product = @p1",connect);
            command.Parameters.AddWithValue("@p1", selectProductTxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            MessageBox.Show("Found");
        }
    }
}
