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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalFormsApp
{
    public partial class FormRegristasi : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi konn = new Koneksi();

        void Bersihkan()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }
        public FormRegristasi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frmlgn = new FormLogin();
            frmlgn.Show();
        }

        private void FormRegristasi_Load(object sender, EventArgs e)
        {
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
                    cmd = new SqlCommand("insert into DataPengguna (Nama,NoTelepon,Password) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("REGRISTASI DATA BERHASIL");
                    Bersihkan();
                }
                catch (Exception G)
                {
                    MessageBox.Show(G.ToString());
                }
            }
        }
    }
}
