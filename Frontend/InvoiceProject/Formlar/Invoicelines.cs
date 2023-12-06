using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace StajProje.Formlar
{
    public partial class Invoicelines : Form
    {

        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        SqlDataReader dr;

        public int invoiceNumber;
        public string productName;

        public Invoicelines(int pinvoiceNumber)
        {
            addInfoTextBox();
            InitializeComponent();
            invoiceNumber = pinvoiceNumber;
          
            //dataGridView1.Rows.Add(invoiceid.ToString());
            dataGridView1.AllowUserToAddRows = false;

            conn = new SqlConnection("server=DESKTOP-91O6FH9\\SQLEXPRESS; Initial Catalog=InvoiceProject;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("Select Product$.name as 'productName', Campaign$.name as 'CampaignName' from Invoice$ " +
                                            "left join Product$ on Product$.productid = Invoice$.productid " +
                                            "left join Campaign$ on Campaign$.campaignid = Invoice$.campaignid "+
                                            "where invoiceNumber = " +pinvoiceNumber, conn);

            conn.Open();
            dr = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;

            conn.Close();
        }

        
       // public string invoiceType;
        
        // productId, count,rate, price, total_price;
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        void addInfoTextBox()
        {

            conn = new SqlConnection();
            SqlDataReader dr;

            conn = new SqlConnection("server=DESKTOP-91O6FH9\\SQLEXPRESS; Initial Catalog=InvoiceProject;Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("SELECT name FROM Campaign$ GROUP BY name HAVING COUNT(*) > 1", conn);
            SqlCommand cmd = new SqlCommand("", conn);

            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
            }

            conn.Close();
        }


        private void Invoicelines_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'productProjectDataSet._Invoiceline_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.invoiceline_TableAdapter.Fill(this.productProjectDataSet._Invoiceline_);
            // TODO: Bu kod satırı 'productProjectDataSet._Invoiceline_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.


            /* invoiceIdTextBox.Text = invoiceId.ToString();
            productIdTextBox.Text = productId.ToString();
            invoiceTypeTextBox.Text = invoiceType;
            countTextBox.Text = count.ToString();
            discount_rateTextBox.Text = rate.ToString();
            priceTextBox.Text = price.ToString();
            total_priceTextBox.Text= total_price.ToString(); */
        }

        private void invoiceline_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceline_BindingSource.EndEdit();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
