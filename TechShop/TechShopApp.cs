using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TechShop
{
    public partial class TechShopApp : Form
    {
        public TechShopApp()
        {
            InitializeComponent();
        }

        // ProductView ViewProduct = new ProductView();
        //ProductDefList ListView = new ProductDefList();
        //LoginPage FormLogin = new LoginPage();

        private void LogBtn_Click_1(object sender, EventArgs e)
        {
            // show login form
            //loginPage1.BringToFront();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            //show user registration page
            //userControl11.BringToFront();
        }

        private void ExistUser_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for shopping with us.");
            Close();
        }

        private void HelpUser_Click_1(object sender, EventArgs e)
        {
            // show default product list          
            // helpPage1.BringToFront();
        }

        private void LoadMore_Click(object sender, EventArgs e)
        {
            //productDefList1.BringToFront();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            // show all pages
            //productDefList1.BringToFront();
        }

        private void ViewMyCart_Click(object sender, EventArgs e)
        {

        }
    }
}
