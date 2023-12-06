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
using System.Configuration;

namespace StajProje.Formlar
{
    public partial class Invoice : Form
    {
        SqlDataAdapter da;
        DataSet ds;

        public Invoice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formlar.Invoicelines line = new Formlar.Invoicelines(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

            /* line.invoiceId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            line.productId = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            line.invoiceType = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            line.count = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            line.rate = int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            line.price = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            line.total_price = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString()); */

            line.Show();


        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'productProjectDataSet._Invoice_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.invoice_TableAdapter.Fill(this.productProjectDataSet._Invoice_);
            // TODO: Bu kod satırı 'productProjectDataSet._Invoice_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            AddTable();
            invoiceIdTextBox.Visible = false;
            addAccountId();
            
            
        }


        void addAccountId()
        {
            comboBoxAccountId.Items.Clear();
            SqlDataReader dr;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Account$", conn);

                    conn.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBoxAccountId.Items.Add(dr["accountid"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
  
        } 


        /* void addCampaignId()
        {
            
            conn = new SqlConnection();
            SqlDataReader dr;

            conn = new SqlConnection("server=DESKTOP-91O6FH9\\SQLEXPRESS; Initial Catalog=ProductProject;Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("SELECT name FROM Campaign$ GROUP BY name HAVING COUNT(*) > 1", conn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Campaign$ where accountid = "+int.Parse(comboBoxAccountId.SelectedItem.ToString()), conn);

            conn.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBoxCampaignId.Items.Add(dr["campaignid"]);
            }

            conn.Close();
        } */
       
        void AddTable()
        {
            /* SqlDataReader dr;

            conn = new SqlConnection("server=DESKTOP-91O6FH9\\SQLEXPRESS; Initial Catalog=ProductProject;Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("SELECT name FROM Campaign$ GROUP BY name HAVING COUNT(*) > 1", conn);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Invoice$", conn);

            
            conn.Open();
            dr = cmd.ExecuteReader();
            

            while (dr.Read())
            {
                
            }

            conn.Close(); */

            SqlDataReader dr;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    ds = new DataSet();

                    SqlCommand cmd = new SqlCommand("Select DISTINCT invoiceNumber, Invoice$.create_date,Account$.accountid ,Account$.name as AccountName, " +
                                            "Account$.address as AccountAddress,Account$.code as 'AccountCode',Campaign$.name as 'CampaignName' from Invoice$ " +
                                            "left join Campaign$ on Campaign$.campaignid = Invoice$.campaignid " +
                                            // "left join Campaign$ on Campaign$.campaignid = Invoice$.campaignid " +
                                            "left join Account$ on Account$.accountid = Invoice$.accountid " +
                                            "left join Product$ on Product$.productid = Invoice$.productid ", conn);


                    da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(ds, "Invoice$");

                    dataGridView1.DataSource = ds.Tables["Invoice$"];
                    this.dataGridView1.Columns["accountid"].Visible = false;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            
            

            //button2.PerformClick();

            /* invoiceNumberTextBox.Text = selectedRow.Cells[0].Value.ToString();
            create_dateDateTimePicker.Value = DateTime.Parse(selectedRow.Cells[1].Value.ToString());
            comboBoxAccountId.SelectedItem = int.Parse(selectedRow.Cells[2].Value.ToString()); */


        }

        private void invoice_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoice_BindingSource.EndEdit();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* invoiceIdTextBox.Text = "";
            invoiceNumberTextBox.Text = ""; */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* conn.Open();
            string add = "insert into Invoice$(accountid,campaignid,invoiceNumber,create_date) values (@accountid,@campaignid,@invoiceNumber,@create_date)";
            SqlCommand komut = new SqlCommand(add, conn);

            
            komut.Parameters.AddWithValue("@accountid", comboBoxAccountId.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@campaignid", int.Parse(comboBoxCampaignId.SelectedItem.ToString()));
            komut.Parameters.AddWithValue("@invoiceNumber", int.Parse(invoiceNumberTextBox.Text));
            komut.Parameters.AddWithValue("@create_date", DateTime.Parse(create_dateDateTimePicker.Value.ToString()));

            komut.ExecuteNonQuery();

            conn.Close();
            AddTable(); */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* conn.Open();
            string add = "update Invoice$ set accountid= @accountid,campaignid= @campaignid,invoiceNumber= @invoiceNumber,create_date =@create_date where invoiceid= @invoiceid";
            SqlCommand komut = new SqlCommand(add, conn);

            komut.Parameters.AddWithValue("@invoiceid", int.Parse(invoiceIdTextBox.Text));
            komut.Parameters.AddWithValue("@accountid", comboBoxAccountId.SelectedItem.ToString());
            komut.Parameters.AddWithValue("@campaignid", int.Parse(comboBoxCampaignId.SelectedItem.ToString()));
            komut.Parameters.AddWithValue("@invoiceNumber", int.Parse(invoiceNumberTextBox.Text));
            komut.Parameters.AddWithValue("@create_date", DateTime.Parse(create_dateDateTimePicker.Value.ToString()));

            komut.ExecuteNonQuery();

            conn.Close();
            AddTable(); */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* conn.Open();
            string add = "Delete from Invoice$ where invoiceid = @invoiceid";
            SqlCommand komut = new SqlCommand(add, conn);

            komut.Parameters.AddWithValue("@invoiceid", int.Parse(invoiceIdTextBox.Text));

            komut.ExecuteNonQuery();

            conn.Close();
            AddTable(); */
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlDataReader dr;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    ds = new DataSet();

                    SqlCommand cmd = new SqlCommand("Select DISTINCT invoiceNumber, Invoice$.create_date,Account$.accountid ,Account$.name as accountName, " +
                                            "Account$.address as AccountAddress,Account$.code as 'AccountCode',Campaign$.name as 'CampaignName' from Invoice$ " +
                                            "left join Campaign$ on Campaign$.campaignid = Invoice$.campaignid " +
                                            "left join Account$ on Account$.accountid = Invoice$.accountid " +
                                            "left join Product$ on Product$.productid = Invoice$.productid " +
                                            "where invoiceNumber like '" + invoiceNumberTextBox.Text + "%' ", conn);

                    da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(ds, "Invoice$");
                    this.dataGridView1.Columns["accountid"].Visible = false;
                    dataGridView1.DataSource = ds.Tables["Invoice$"];

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBoxAccountId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataReader dr;
            comboBoxCampaignId.Items.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Campaign$ where accountid = " + int.Parse(comboBoxAccountId.SelectedItem.ToString()), conn);

                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBoxCampaignId.Items.Add(dr["campaignid"]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
       
        }
    }
}
