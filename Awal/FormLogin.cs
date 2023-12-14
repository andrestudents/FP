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
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        Koneksi konn = new Koneksi();
        public FormLogin()
        {
            InitializeComponent();
            pictureBox4.MouseEnter += PictureBox4_MouseEnter;
            pictureBox4.MouseLeave += PictureBox4_MouseLeave;

             void PictureBox4_MouseEnter(object sender, EventArgs e)
            {
                // Ganti warna latar belakang atau efek visual lainnya ketika cursor masuk
                pictureBox4.BackColor = Color.Red;
            }

             void PictureBox4_MouseLeave(object sender, EventArgs e)
            {
                // Kembalikan warna latar belakang atau efek visual ke nilai awal ketika cursor keluar
                pictureBox4.BackColor = Color.White;
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                this.Hide();
                FormMenuUtama FrmUtama = new FormMenuUtama();
                FrmUtama.Show();
            }

            SqlConnection Conn = konn.Getconn();
            Conn.Open();
            cmd = new SqlCommand("SELECT * from DataPengguna where Nama = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", Conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {

                FormMenuUtama1 frmUtama = new FormMenuUtama1();
                frmUtama.Show();
                this.Hide();
                Conn.Close();
            }
            else
            {
                MessageBox.Show("Wrong !!!");
            }
           

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegristasi Reg = new FormRegristasi();
            Reg.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
