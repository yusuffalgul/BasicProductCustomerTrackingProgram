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
    public partial class CustomerOperations : Form
    {
        public CustomerOperations()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-7DEH5NV\\MSSQLSERVER02;Initial Catalog=ProductStock;Integrated Security=True");


        private void CustomerOperations_Load(object sender, EventArgs e)
        {
            
           
        }

        private void customerAddButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("INSERT into Customer (Identification,Name,Surname,Age) values (@p1,@p2,@p3,@p4)", connect);
            command.Parameters.AddWithValue("@p1", customerIdTxt.Text);
            command.Parameters.AddWithValue("@p2", customerNameTxt.Text);
            command.Parameters.AddWithValue("@p3", customerSurnameTxt.Text);
            command.Parameters.AddWithValue("@p4", customerAgeTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Customer Added");
        }

        private void customerSelectButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Customer", connect);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            MessageBox.Show("Found");
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Customer WHERE Identification = @p1",connect);
            command.Parameters.AddWithValue("@p1", deleteCustomerIdTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Customer Deleted");

        }

        private void updateIdButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("UPDATE Customer SET Identification = @p1 WHERE Id = @p2",connect);
            command.Parameters.AddWithValue("@p1",updateCustomerIdenTxt.Text);
            command.Parameters.AddWithValue("@p2",updateCustomerIdTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Customer Identification Updated");
        }

        private void updateNameButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("UPDATE Customer SET Name = @p1 WHERE Id = @p2",connect);
            command.Parameters.AddWithValue("@p1",updateCustomerNameTxt.Text);
            command.Parameters.AddWithValue("@p2", updateCustomerIdTxt.Text);
            command.ExecuteNonQuery();
            connect.Close ();
            MessageBox.Show("Customer Name Updated");
        }

        private void updateSurnameButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("UPDATE Customer SET Surname = @p1 WHERE Id = @p2", connect);
            command.Parameters.AddWithValue("@p1", updateCustomerSurnameTxt.Text);
            command.Parameters.AddWithValue("@p2", updateCustomerIdTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Customer Surname Updated");
        }

        private void updateAgeButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("UPDATE Customer SET Age = @p1 WHERE Id = @p2", connect);
            command.Parameters.AddWithValue("@p1", updateCustomerAgeTxt.Text);
            command.Parameters.AddWithValue("@p2", updateCustomerIdTxt.Text);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Customer Age Updated");
        }



        private void nameSelectButton_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE Name = @p1", connect);
            command.Parameters.AddWithValue("@p1", nameSelectTxt.Text);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
            MessageBox.Show("Found");
        }


    }
}
