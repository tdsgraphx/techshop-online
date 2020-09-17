using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TechShop
{
    public partial class ProductDefList : UserControl
    {
        public ProductDefList()
        {
            InitializeComponent();
        }


        //ProductView ViewProduct = new ProductView();
       // ProductDefList ListView = new ProductDefList();
        //LoginPage FormLogin = new LoginPage();

        public void DisplayInterface()
        {
            Hide();
           //FormLogin.Hide();
           //ViewProduct.Show();

            // prduct button programming
            for (int i = 1; i < 6; i++)
            {

                //ListView.ProductBtn[i];
            }
        }

        private void ProductBtn1_Click_1(object sender, EventArgs e)
        {
            DisplayInterface();
        }

        private void ProductBtn2_Click_1(object sender, EventArgs e)
        {
            DisplayInterface();
        }

        private void ProductBtn3_Click_1(object sender, EventArgs e)
        {
            DisplayInterface();

        }

        private void ProductBtn4_Click_1(object sender, EventArgs e)
        {
            DisplayInterface();
        }

        private void ProductBtn5_Click_1(object sender, EventArgs e)
        {
            DisplayInterface();
        }

        private void ProductBtn6_Click_1(object sender, EventArgs e)
        {
            DisplayInterface();
        }
    }
}
