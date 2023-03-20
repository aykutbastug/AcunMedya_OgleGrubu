
using System.Data;
using System.Data.SqlClient;

namespace _01_Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString1 = "server=AYKUTBASTUG-ZEN; database=Northwind;Trusted_Connection=true;";

        private void button1_Click(object sender, EventArgs e)
        {
            KategorileriDoldur();
        }

        private void KategorileriDoldur()
        {

            //string connectionString2 = "server=AYKUTBASTUG-ZEN; database=Northwind;uid=sa;pwd=1qaz2wsxA;";
            //string connectionString3 = "server=AYKUTBASTUG-ZEN; database=Northwind;user id=sa;password=1qaz2wsxA;";
            //string connectionString4 = "data source=AYKUTBASTUG-ZEN; Initial Catalog=Northwind;Integrated Security=true;";

            SqlConnection cn = new SqlConnection(connectionString1);
            //SqlConnection cn = new SqlConnection("server=AYKUTBASTUG-ZEN; database=Northwind;Trusted_Connection=true;");

            cn.Open();
            //SqlCommand cmd = new SqlCommand("sql komutu", cn);
            //SqlCommand cmd = new SqlCommand("select * from dbo.Categories", cn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "select * from dbo.Categories";

            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("CategoryId", typeof(int));
            dt.Columns.Add("CategoryName", typeof(string));
            dt.Columns.Add("Description", typeof(string));

            while (reader.Read())
            {
                dt.Rows.Add(reader["CategoryId"], reader["CategoryName"], reader["Description"]);
                //dt.Rows.Add(reader[0], reader[1], reader[2]);
            }

            reader.Close();
            cn.Close();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
        }


        private void KategorileriDoldurYeni()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString1);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from dbo.Categories", sqlConnection);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriDoldur();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString1);
            //SqlCommand cmd = new SqlCommand("insert into dbo.Categories (CategoryName, Description) values ('"+txtCategoryName.Text+"', '"+txtDescription.Text+"')");

            //SqlCommand cmd = new SqlCommand($"insert into dbo.Categories (CategoryName, Description) values ('{txtCategoryName.Text}', '{txtDescription.Text}')", cn);

            SqlCommand cmd = new SqlCommand($"insert into dbo.Categories (CategoryName, Description) values (@name, @desc)", cn);
            cmd.Parameters.AddWithValue("name", txtCategoryName.Text);
            cmd.Parameters.AddWithValue("desc", txtDescription.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            KategorileriDoldur();

            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            txtDescription.Text = "";

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connectionString1);
            SqlCommand cmd = new SqlCommand($"update dbo.Categories set CategoryName=@name, Description=@desc where CategoryId=@id", cn);
            cmd.Parameters.AddWithValue("name", txtCategoryName.Text);
            cmd.Parameters.AddWithValue("desc", txtDescription.Text);
            cmd.Parameters.AddWithValue("id", txtCategoryId.Text);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            KategorileriDoldur();

            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            txtDescription.Text = "";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{txtCategoryName.Text} isimli kategoriyi silmek istiyor musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                SqlConnection sqlConnection = new SqlConnection(connectionString1);
                SqlCommand cmd = new SqlCommand("delete from dbo.Categories where CategoryId=@id", sqlConnection);
                cmd.Parameters.AddWithValue("id", txtCategoryId.Text);
                sqlConnection.Open();
                cmd.ExecuteNonQuery();
                sqlConnection.Close();
                KategorileriDoldur();

                txtCategoryId.Text = "";
                txtCategoryName.Text = "";
                txtDescription.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem sırasında hata oluştu.\nHata Mesajı :" + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            txtCategoryId.Text = "";
            txtCategoryName.Text = "";
            txtDescription.Text = "";

            if (dataGridView1.CurrentRow == null)
                return;

            txtCategoryId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCategoryName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDescription.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KategorileriDoldurYeni();
        }
    }
}