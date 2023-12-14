using FinalFormsApp.DaftarFilm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalFormsApp
{
    public partial class FormMenuUtama1 : Form
    {
        public FormMenuUtama1()
        {
            InitializeComponent();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film1 film1 = new Film1();
            film1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film2 film2 = new Film2();
            film2.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film3 film3 = new Film3();
            film3.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film4 film4 = new Film4();
            film4.Show();

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film5 film5 = new Film5();
            film5.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film6 film6 = new Film6();
            film6.Show();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film7 film7 = new Film7();
            film7.Show();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Film8 film8 = new Film8();
            film8.Show();
        }

       
    }
}
