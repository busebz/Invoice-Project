using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Formlar.Products products = new Formlar.Products();
            products.Show();
            
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            Formlar.Account account = new Formlar.Account();
            account.Show();
            
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            Formlar.Invoice invoice = new Formlar.Invoice();
            invoice.Show();
            
        }
    }
}
