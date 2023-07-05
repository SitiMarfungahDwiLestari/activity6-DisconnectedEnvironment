using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class prodi : Form
    {
        private string stringConnection = "Data source = LAPTOP-IH6NG1MN\\SITI_MARFUNGAH; " + "database=activity6;User ID=hallo;Password=12345";
        private SqlConnection koneksi;

        private void refreshform()
        {
            textBox1.Text = "";
            add.Enabled = false;
            save.Enabled = false;
            clear.Enabled = false;
        }

        public prodi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView1_CellContentClick_1()
        {

            koneksi.Open();
            string str = "select nama_prodi from dbo.prodi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void open_Click(object sender, EventArgs e)
        {
            dataGridView1_CellContentClick_1();
            open.Enabled = false;
        }

        private void add_Click(object sender, EventArgs e)
        {
            add.Enabled = true;
            save.Enabled = true;
            clear.Enabled = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string nmProdi = add.Text;

            if (nmProdi == "")
            {
                MessageBox.Show("Masukkan Nama Prodi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.Prodi (nama_prodi)" + "values(@id)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", nmProdi));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1_CellContentClick_1();
                refreshform();
            }
        }


        private void prodi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'activity6DataSet.prodi' table. You can move, or remove it, as needed.
            this.prodiTableAdapter.Fill(this.activity6DataSet.prodi);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
