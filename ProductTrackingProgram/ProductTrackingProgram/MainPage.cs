using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductTrackingProgram
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void productOpButton_Click(object sender, EventArgs e)
        {
            ProductOperations productOperations = new ProductOperations();
            productOperations.Show();
            this.Hide();
        }

        private void customerOpButton_Click(object sender, EventArgs e)
        {
            CustomerOperations customerOperations = new CustomerOperations();
            customerOperations.Show();
            this.Hide();
        }

        private void graphicsButton_Click(object sender, EventArgs e)
        {
            Graphics graphics = new Graphics();
            graphics.Show();
            this.Hide();
        }
    }
}
