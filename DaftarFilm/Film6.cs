using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalFormsApp.DaftarFilm
{
    public partial class Film6 : Form
    {
        public Film6()
        {
            InitializeComponent();
            pictureBox2.MouseEnter += PictureBox4_MouseEnter;
            pictureBox2.MouseLeave += PictureBox4_MouseLeave;

            void PictureBox4_MouseEnter(object sender, EventArgs e)
            {
                // Ganti warna latar belakang atau efek visual lainnya ketika cursor masuk
                pictureBox2.BackColor = Color.Red;
            }

            void PictureBox4_MouseLeave(object sender, EventArgs e)
            {
                // Kembalikan warna latar belakang atau efek visual ke nilai awal ketika cursor keluar
                pictureBox2.BackColor = Color.White;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenuUtama1 f1 = new FormMenuUtama1();
            f1.Show(this);
        }
    }
}
