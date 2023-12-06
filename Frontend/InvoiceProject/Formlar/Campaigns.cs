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
    public partial class Campaigns : Form
    {

        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public Campaigns()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CampaignDetail det = new CampaignDetail();
            det.Show();
        }

        private void Campaigns_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'productProjectDataSet._Campaign_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.campaign_TableAdapter.Fill(this.productProjectDataSet._Campaign_);
            // TODO: Bu kod satırı 'productProjectDataSet._Campaign_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.campaign_TableAdapter.Fill(this.productProjectDataSet._Campaign_);
            AddTable();
            addAccountId();
            campaignIdTextBox.Visible = false;
            
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

        void AddTable()
        {
            SqlDataReader dr;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    ds = new DataSet();

                    SqlCommand cmd = new SqlCommand("Select campaignid,Campaign$.accountid,Campaign$.name,discount_rate,start_date,end_date from Campaign$ " +
                "inner join Account$ on Account$.accountid = Campaign$.accountid ", conn);


                    da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(ds, "Campaign$");
                    dataGridView1.DataSource = ds.Tables["Campaign$"];
                    this.dataGridView1.Columns["campaignid"].Visible = false;
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

        private void campaign_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            campaignIdTextBox.Text = selectedRow.Cells[0].Value.ToString();
            comboBoxAccountId.SelectedItem = int.Parse(selectedRow.Cells[1].Value.ToString());
            nameTextBox.Text = selectedRow.Cells[2].Value.ToString();
            discount_rateTextBox.Text = selectedRow.Cells[3].Value.ToString();
            start_dateDateTimePicker.Value = DateTime.Parse(selectedRow.Cells[4].Value.ToString());
            end_dateDateTimePicker.Value = DateTime.Parse(selectedRow.Cells[5].Value.ToString());
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "insert into Campaign$(accountid,name,discount_rate,start_date,end_date) values (@accountid,@name,@discount_rate,@start_date,@end_date)";
                    SqlCommand command = new SqlCommand(add, conn);

                    //komut.Parameters.AddWithValue("@campaignid", int.Parse(campaignIdTextBox.Text));
                    command.Parameters.AddWithValue("@accountid", int.Parse(comboBoxAccountId.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@discount_rate", int.Parse(discount_rateTextBox.Text));
                    command.Parameters.AddWithValue("@start_date", DateTime.Parse(start_dateDateTimePicker.Value.ToString()));
                    command.Parameters.AddWithValue("@end_date", DateTime.Parse(end_dateDateTimePicker.Value.ToString()));

                    command.ExecuteNonQuery();

                    conn.Close();
                    AddTable();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {

                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            campaignIdTextBox.Text = "";
            //comboBoxAccountId.SelectedItem = "";
            nameTextBox.Text = "";
            discount_rateTextBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "update Campaign$ set accountid = @accountid, name=@name,discount_rate= @discount_rate,start_date= @start_date,end_date= @end_date where campaignid = @campaignid";
                    SqlCommand command = new SqlCommand(add, conn);

                    command.Parameters.AddWithValue("@campaignid", int.Parse(campaignIdTextBox.Text));
                    command.Parameters.AddWithValue("@accountid", int.Parse(comboBoxAccountId.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@discount_rate", int.Parse(discount_rateTextBox.Text));
                    command.Parameters.AddWithValue("@start_date", DateTime.Parse(start_dateDateTimePicker.Value.ToString()));
                    command.Parameters.AddWithValue("@end_date", DateTime.Parse(end_dateDateTimePicker.Value.ToString()));

                    command.ExecuteNonQuery();

                    conn.Close();
                    AddTable();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "Delete from Campaign$ where campaignid = @campaignid";
                    SqlCommand command = new SqlCommand(add, conn);

                    command.Parameters.AddWithValue("@campaignid", int.Parse(campaignIdTextBox.Text));

                    command.ExecuteNonQuery();

                    conn.Close();
                    AddTable();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hata: " + ex.Message);
                }
                finally
                {

                }
            } 
        }
    }
}
