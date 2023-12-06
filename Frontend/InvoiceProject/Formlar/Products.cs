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
    public partial class Products : Form
    {

        SqlDataAdapter da;
        DataSet ds;

        public Products()
        {
            InitializeComponent();
            
        }

        private void Products_Load(object sender, EventArgs e)
        {
            griddoldur();
            addCategoryId();
            textBoxProductId.Visible = false;
            
        }

        void addCategoryId()
        {
            comboBoxCategoryId.Items.Clear();
            SqlDataReader dr;

            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select * from Category$", conn);

                    conn.Open();
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        comboBoxCategoryId.Items.Add(dr["name"]);
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

        
        void griddoldur()
        {
            SqlDataReader dr;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    ds = new DataSet();

                    string add = "Select productid,Product$.code,Product$.name,categoryid,color,width,height,price,create_date from Product$ " +
                        "inner join Category$ on category_id = categoryid";
                    SqlCommand cmd = new SqlCommand(add, conn);
                    da = new SqlDataAdapter(cmd);

                    conn.Open();

                    da.Fill(ds, "Product$");
                    dataGridView1.DataSource = ds.Tables["Product$"];
                    this.dataGridView1.Columns["productid"].Visible = false;
                    this.dataGridView1.Columns["categoryid"].Visible = false;

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


        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Excel Dosyası |*.xlsx| Excel Dosyası |*.xls";
            o.Title = "Select Product File";
            if (o.ShowDialog() == DialogResult.OK)
            {
                OleDbConnection connect;
                connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + o.FileName + "; Extended Properties='Excel 12.0 xml;HDR=YES;'");
                connect.Open();
                OleDbDataAdapter adap = new OleDbDataAdapter("Select * from [Product$]", connect);
                DataTable dt = new DataTable();
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
                connect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            cat.ShowDialog();
            addCategoryId();
            griddoldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Campaigns cam = new Campaigns();
            cam.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "insert into Product$(code,name,categoryid,color,width,height,price,create_date) values (@code,@name,@categoryid,@color,@width,@height,@price,@create_date)";
                    SqlCommand command = new SqlCommand(add, conn);


                    command.Parameters.AddWithValue("@code", int.Parse(textBoxCode.Text));
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@categoryid", int.Parse(comboBoxCategoryId.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@color", textBoxColor.Text);
                    command.Parameters.AddWithValue("@width", int.Parse(textBoxWidth.Text));
                    command.Parameters.AddWithValue("@height", int.Parse(textBoxHeight.Text));
                    command.Parameters.AddWithValue("@price", int.Parse(textBoxPrice.Text));

                    command.Parameters.AddWithValue("@create_date", DateTime.Parse(dateTimePicker1.Value.ToString()));

                    command.ExecuteNonQuery();
                    conn.Close();
                    griddoldur();

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];

            textBoxProductId.Text = selectedRow.Cells[0].Value.ToString();
            textBoxCode.Text = selectedRow.Cells[1].Value.ToString();
            textBoxName.Text = selectedRow.Cells[2].Value.ToString();
            comboBoxCategoryId.SelectedItem= int.Parse( selectedRow.Cells[3].Value.ToString());
            textBoxColor.Text = selectedRow.Cells[4].Value.ToString();
            textBoxWidth.Text = selectedRow.Cells[5].Value.ToString();
            textBoxHeight.Text = selectedRow.Cells[6].Value.ToString();
            textBoxPrice.Text = selectedRow.Cells[7].Value.ToString();
            dateTimePicker1.Value = DateTime.Parse(selectedRow.Cells[8].Value.ToString());

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedItem = int.Parse("0");
            textBoxCode.Text = "";
            textBoxName.Text = "";
            //comboBox2.SelectedItem = int.Parse("0");
            textBoxColor.Text = "";
            textBoxWidth.Text = "";
            textBoxHeight.Text = "";
            textBoxPrice.Text = "";           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "update Product$ set code = @code, name = @name, categoryid = @categoryid, color = @color, width = @width, height= @height, price = @price, create_date = @create_date where productid = " + textBoxProductId.Text + "";
                    SqlCommand command = new SqlCommand(add, conn);

                    //komut.Parameters.AddWithValue("@productid", int.Parse(comboBoxProductId.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@code", int.Parse(textBoxCode.Text));
                    command.Parameters.AddWithValue("@name", textBoxName.Text);
                    command.Parameters.AddWithValue("@categoryid", int.Parse(comboBoxCategoryId.SelectedItem.ToString()));
                    command.Parameters.AddWithValue("@color", textBoxColor.Text);
                    command.Parameters.AddWithValue("@width", int.Parse(textBoxWidth.Text));
                    command.Parameters.AddWithValue("@height", int.Parse(textBoxHeight.Text));
                    command.Parameters.AddWithValue("@price", int.Parse(textBoxPrice.Text));
                    command.Parameters.AddWithValue("@create_date", DateTime.Parse(dateTimePicker1.Value.ToString()));

                    command.ExecuteNonQuery();

                    conn.Close();
                    griddoldur();

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

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string add = "Delete from Product$ where productid = @productid";
                    SqlCommand command = new SqlCommand(add, conn);

                    command.Parameters.AddWithValue("@productid", textBoxProductId.Text);

                    command.ExecuteNonQuery();

                    conn.Close();
                    griddoldur();

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
