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
    public partial class Account : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        public Account()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Account_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'productProjectDataSet._Account_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.account_TableAdapter.Fill(this.productProjectDataSet._Account_);

            
            AddTable();
            accountIdTextBox.Visible = false;
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

                    da = new SqlDataAdapter("Select * From Account$", conn);
                    conn.Open();
                    da.Fill(ds, "Account$");
                    dataGridView1.DataSource = ds.Tables["Account$"];
                    this.dataGridView1.Columns["accountid"].Visible = false;
                    conn.Close();
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

            accountIdTextBox.Text = selectedRow.Cells[0].Value.ToString();
            accountTypeTextBox.Text = selectedRow.Cells[1].Value.ToString();
            nameTextBox.Text = selectedRow.Cells[2].Value.ToString();
            codeTextBox.Text = selectedRow.Cells[3].Value.ToString();
            addressTextBox.Text = selectedRow.Cells[4].Value.ToString();
            
        }

        private void account_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "insert into Account$(accountType,name,code,address) values (@accountType,@name,@code,@address)";
                    SqlCommand command = new SqlCommand(add, conn);

                    //komut.Parameters.AddWithValue("@accountid", int.Parse(accountIdTextBox.Text));
                    command.Parameters.AddWithValue("@accountType", accountTypeTextBox.Text);
                    command.Parameters.AddWithValue("@name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@code", int.Parse(codeTextBox.Text));
                    command.Parameters.AddWithValue("@address", addressTextBox.Text);

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

        private void button4_Click(object sender, EventArgs e)
        {
           
            accountTypeTextBox.Text = "";
            nameTextBox.Text = "";
            codeTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "update Account$ set accountType= @accountType,name= @name,code= @code,address= @address where accountid= @accountid ";
                    SqlCommand command = new SqlCommand(add, conn);

                    command.Parameters.AddWithValue("@accountid", int.Parse(accountIdTextBox.Text));
                    command.Parameters.AddWithValue("@accountType", accountTypeTextBox.Text);
                    command.Parameters.AddWithValue("@name", nameTextBox.Text);
                    command.Parameters.AddWithValue("@code", int.Parse(codeTextBox.Text));
                    command.Parameters.AddWithValue("@address", addressTextBox.Text);

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

         private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "Delete from Account$ where accountid= @accountid ";
                    SqlCommand command = new SqlCommand(add, conn);

                    command.Parameters.AddWithValue("@accountid", int.Parse(accountIdTextBox.Text));

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
