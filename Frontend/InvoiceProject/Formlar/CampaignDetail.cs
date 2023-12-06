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
    public partial class CampaignDetail : Form
    {

        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public CampaignDetail()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void CampaignDetail_Load(object sender, EventArgs e)
        {
            textBoxCampaignId.Text = "";
            textBoxProductId.Text = "";
            textBoxDiscountRate.Text = "";

            AddTable();
            addCampaignId();
            addProductId();
            addDiscountRate();

            campDetailIdTextBox.Visible = false;
        }

        void addCampaignId()
        {

            SqlDataReader dr;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Campaign$", conn);

                    conn.Open();
                    dr = cmd.ExecuteReader();


                    if (dr.Read())
                    {

                        textBoxCampaignId.Text = dr["campaignid"].ToString();
                        textBoxCampaignId.Text = "";
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

        void addProductId()
        {
            SqlDataReader dr;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Product$", conn);

                    conn.Open();
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        textBoxProductId.Text = dr["productid"].ToString();
                        textBoxProductId.Text = "";
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

        void addDiscountRate()
        {
            SqlDataReader dr;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Campaign$", conn);

                    conn.Open();
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        textBoxDiscountRate.Text = dr["discount_rate"].ToString();
                        textBoxDiscountRate.Text = "";
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

                    SqlCommand cmd = new SqlCommand("Select campaigndetailid,Campaigndetail$.campaignid,Campaigndetail$.productid, Campaigndetail$.discount_rate from Campaigndetail$ " +
                "inner join Campaign$ on Campaign$.campaignid = Campaigndetail$.campaignid " +
                "inner join Product$ on Product$.productid = Campaigndetail$.productid", conn);


                    da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(ds, "Campaigndetail$");
                    dataGridView1.DataSource = ds.Tables["Campaigndetail$"];
                    this.dataGridView1.Columns["campaigndetailid"].Visible = false;
                    this.dataGridView1.Columns["campaignid"].Visible = false;
                    this.dataGridView1.Columns["productid"].Visible = false;
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

        private void campaigndetail_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            textBoxCampaignId.Text = selectedRow.Cells[1].Value.ToString();
            textBoxProductId.Text = selectedRow.Cells[2].Value.ToString();
            textBoxDiscountRate.Text = selectedRow.Cells[3].Value.ToString();
        }
    }
}
