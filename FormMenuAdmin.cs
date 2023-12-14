using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalFormsApp
{
    public partial class FormMenuAdmin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi konn = new Koneksi();
        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        void TampilkanData()
        {
            SqlConnection con = konn.Getconn();
            try
            {
                con.Open();
                cmd = new SqlCommand("Select PemesanID,Nama,NoTelepon from DataPemesan", con);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "DataPemesan");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "DataPemesan";



            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        void CariData()
        {
            SqlConnection con = konn.Getconn();
            try
            {
                con.Open();
                cmd = new SqlCommand("Select PemesanID,Nama,NoTelepon from DataPemesan where PemesanID like '%" + textBox4.Text + "%' or Nama like '%" + textBox4.Text + "%'", con);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "DataPemesan");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "DataPemesan";



            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMenuPesan_Load(object sender, EventArgs e)
        {
            TampilkanData();
            Bersihkan();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("DATA BELUM LENGKAP");
            }
            else
            {
                SqlConnection conn = konn.Getconn();
                try
                {
                    cmd = new SqlCommand("insert into DataPemesan (PemesanID,Nama,NoTelepon) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("INSERT DATA BERHASIL");
                    TampilkanData();
                    Bersihkan();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["PemesanID"].Value.ToString();
                textBox2.Text = row.Cells["Nama"].Value.ToString();
                textBox3.Text = row.Cells["NoTelepon"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "")
            {
                MessageBox.Show("DATA BELUM LENGKAP");
            }
            else
            {
                SqlConnection conn = konn.Getconn();
                try
                {
                    cmd = new SqlCommand("update DataPemesan Set Nama = '" + textBox2.Text + "',NoTelepon ='" + textBox3.Text + "'where PemesanID = '" + textBox1.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("UPDATE DATA BERHASIL");
                    TampilkanData();
                    Bersihkan();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin menghapus data : " + textBox2.Text + "?" , "Konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = konn.Getconn();
                
                {
                    cmd = new SqlCommand("DELETE DataPemesan where Nama = '" + textBox2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("HAPUS DATA BERHASIL");
                    TampilkanData();
                    Bersihkan();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bersihkan();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CariData();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuUtama frmutama = new FormMenuUtama();
            frmutama.Show();
        }
    }
}