using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disconnected_Environment
{
    public partial class Mhs : Form
    {
        private string stringConnection = "Data source = LAPTOP-IH6NG1MN\\SITI_MARFUNGAH; " + "database=activity6;User ID=hallo;Password=12345";
        private SqlConnection koneksi;
        private string nim, nama, alamat, jk, prodi;
        private DateTime tgl;
        BindingSource customersBindingSource = new BindingSource();

        private void Mhs_Load()
        {
            koneksi.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(new SqlCommand("Select m.nim, m.nama_mahasiswa, m.alamat, m.jenis_kelamin, m.tgl_lahir, p.nama_prodi, From dbo.mahasiswa m join dbo.prodi p on m.id_prodi = p.id_prodi", koneksi));
            DataSet ds = new DataSet();
            dataAdapter1.Fill(ds);

            this.customersBindingSource.DataSource = ds.Tables[0];
            this.txtNim.DataBindings.Add(new Binding("Text", this.customersBindingSource, "NIM", true));
            this.txtNama.DataBindings.Add(new Binding("Text", this.customersBindingSource, "nama_mahasiswa", true));
            this.txtAlamat.DataBindings.Add(new Binding("Text", this.customersBindingSource, "alamat", true));
            this.jeniskel.DataBindings.Add(new Binding("Text", this.customersBindingSource, "jenis_kelamin", true));
            this.dateTimePicker1.DataBindings.Add(new Binding("Text", this.customersBindingSource, "tgl_lahir", true));
            this.cbxProdi.DataBindings.Add(new Binding("Text", this.customersBindingSource, "nama_prodi", true));
            koneksi.Close();
        }

        private void clearBinding()
        {
            this.txtNim.DataBindings.Clear();
            this.txtNama.DataBindings.Clear();
            this.txtAlamat.DataBindings.Clear();
            this.jeniskel.DataBindings.Clear();
            this.dateTimePicker1.DataBindings.Clear();
            this.cbxProdi.DataBindings.Clear();
        }


        private void refreshform()
        {
            txtNim.Enabled = false;
            txtNama.Enabled = false;
            jeniskel.Enabled = false;
            txtAlamat.Enabled = false;
            dateTimePicker1.Enabled = false;
            cbxProdi.Enabled = false;
            add.Enabled = true;
            save.Enabled = false;
            clear.Enabled = false;
            clearBinding();
            Mhs_Load();
        }

        public Mhs()
        {
            InitializeComponent();
/*            koneksi = new SqlConnection(kstr);
            this.bnMahasiswa.BindingSource = customersBindingSource;*/
            refreshform();
        }

        private void cbxProdi_SelectedIndexChanged()
        {
            koneksi.Open();
            string str = "Select nama_prodi from dbo.prodi";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();
            cbxProdi.DisplayMember = "nama_prodi";
            cbxProdi.ValueMember = "id_prodi";
            cbxProdi.DataSource = ds.Tables[0];
        }
        
        private void add_Click(object sender, EventArgs e)
        {
            txtNim.Text = "";
            txtNama.Text = "";
            txtAlamat.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            txtNim.Enabled = true;
            txtNama.Enabled = true;
            txtAlamat.Enabled = true;
            jeniskel.Enabled = true;
            dateTimePicker1.Enabled = true;
            cbxProdi.Enabled = true;
            cbxProdi_SelectedIndexChanged();
            save.Enabled = true;
            clear.Enabled = true;
            add.Enabled = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            nim = txtNim.Text;
            nama = txtNama.Text;
            jk = jeniskel.Text;
            alamat = txtAlamat.Text;
            tgl = dateTimePicker1.Value;
            prodi = cbxProdi.Text;
            int hs = 0;
            koneksi.Open();
            string strs = "Select id_prodi from dbo.prodi where nama_prodi = @dd";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@dd", prodi));
            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                hs = int.Parse(dr["id_prodi"].ToString());
            }
            dr.Close();
            string str = "insert into dbo.mahasiswa (nim, nama_mahasiswa, jenis_kelamin, alamat, tgl_lahir, id_prodi)" +  "values (@NIM, @Nm, @Jk, @Al, @Tgll, @Idp)";
            SqlCommand cmd = new SqlCommand(str, koneksi);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("NIM", nim));
            cmd.Parameters.Add(new SqlParameter("Nm", nama));
            cmd.Parameters.Add(new SqlParameter("Jk", jk));
            cmd.Parameters.Add(new SqlParameter("Al", alamat));
            cmd.Parameters.Add(new SqlParameter("Tgll", tgl));
            cmd.Parameters.Add(new SqlParameter("Idp", hs));
            cmd.ExecuteNonQuery();

            koneksi.Close();

            MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            refreshform();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNim_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void jeniskel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

       

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
