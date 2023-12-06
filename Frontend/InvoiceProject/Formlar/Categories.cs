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
    public partial class Categories : Form
    {

        SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;

        public Categories()
        {
            InitializeComponent();
        }

        private void btnCat_Click(object sender, EventArgs e)
        { 
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'productProjectDataSet._Category_' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            // this.category_TableAdapter.Fill(this.productProjectDataSet._Category_);
            AddTable();
            label1.Visible = false;
            textBoxCategoryId.Visible = false;

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

                    SqlCommand cmd = new SqlCommand("Select * from Category$", conn);

                    da = new SqlDataAdapter(cmd);
                    conn.Open();
                    da.Fill(ds, "Category$");
                    dataGridView1.DataSource = ds.Tables["Category$"];
                    this.dataGridView1.Columns["category_id"].Visible = false;

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

        private void category_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            codeTextBox.Text = selectedRow.Cells[1].Value.ToString();
            nameTextBox.Text = selectedRow.Cells[2].Value.ToString();
            textBoxCategoryId.Text = selectedRow.Cells[0].Value.ToString();

        }

        private void category_BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "insert into Category$(code,name) values (@code,@name)";
                    SqlCommand command = new SqlCommand(add, conn);

                    //komut.Parameters.AddWithValue("@category_id", int.Parse(textBoxCategoryId.Text));
                    command.Parameters.AddWithValue("@code", int.Parse(codeTextBox.Text));
                    command.Parameters.AddWithValue("@name", nameTextBox.Text);

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
                    string add = "Delete from Category$ where category_id = @category_id";
                    SqlCommand command = new SqlCommand(add, conn);

                    command.Parameters.AddWithValue("@category_id", int.Parse(textBoxCategoryId.Text));

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
                    string add = "update Category$ set code=@code, name= @name where category_id=" + textBoxCategoryId.Text + "";
                    SqlCommand command = new SqlCommand(add, conn);

                    //komut.Parameters.AddWithValue("@category_id", int.Parse(textBoxCategoryId.Text));
                    command.Parameters.AddWithValue("@code", int.Parse(codeTextBox.Text));
                    command.Parameters.AddWithValue("@name", nameTextBox.Text);

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
