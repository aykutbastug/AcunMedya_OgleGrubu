using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace _03_StoredProcedure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string connectionString = "server=AYKUTBASTUG-ZEN; database=Northwind;Trusted_Connection=true;";

        private void Form1_Load(object sender, EventArgs e)
        {
            MusterileriListele();
        }

        private void MusterileriListele()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());
            SqlDataAdapter da = new SqlDataAdapter("select * from dbo.Customers where CompanyName like '%' + @param1 + '%'", cn);
            da.SelectCommand.Parameters.AddWithValue("param1", textBox1.Text);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            MusterileriListele();
        }

        private void btnYeniMusteriEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            MusterileriListele();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.txtMusteriNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            form3.txtMusteriAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            form3.txtTelefon.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            form3.ShowDialog();
            MusterileriListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"{dataGridView1.CurrentRow.Cells[1].Value.ToString()} isimli müşteriyi silmek istiyor musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ToString());
            SqlCommand sqlCommand = new SqlCommand("sp_CustomerDelete", cn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("CustomerID", dataGridView1.CurrentRow.Cells[0].Value.ToString());

            cn.Open();
            sqlCommand.ExecuteNonQuery();
            cn.Close();

            MusterileriListele();
        }
    }
}