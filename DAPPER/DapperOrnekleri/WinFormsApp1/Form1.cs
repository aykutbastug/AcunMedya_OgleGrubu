using Dapper;
using System;
using System.Data.SqlClient;
using System.Security.Policy;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            using (SqlConnection sqlConnection = new SqlConnection("server=AYKUTBASTUG-ZEN; database=Northwind;Trusted_Connection=true;"))
            {
                //List<dynamic> musteriler = sqlConnection.Query<dynamic>("select * from dbo.Customers").ToList();
                List<Customer> musteriler = sqlConnection.Query<Customer>("select * from dbo.Customers").ToList();

                dataGridView1.DataSource = musteriler;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //using (SqlConnection sqlConnection = new SqlConnection("server=AYKUTBASTUG-ZEN; database=Northwind;Trusted_Connection=true;"))
            //{
            //    List<Customer> musteriler = sqlConnection.Query<Customer>("select * from dbo.Customers where CompanyName like '%'+@param1+'%'", new { param1 = textBox1.Text }).ToList();

            //    dataGridView1.DataSource = musteriler;
            //}


            MusterileriListele();
        }

        private void MusterileriListele()
        {
            List<Customer> musteriler = UygulamaAyarlari.MyConnection.Query<Customer>("select * from dbo.Customers where CompanyName like '%'+@param1+'%'", new { param1 = textBox1.Text }).ToList();
            dataGridView1.DataSource = musteriler;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            MusterileriListele();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            label2.Text = ((Customer)dataGridView1.CurrentRow.DataBoundItem).Phone;
        }
    }
}
