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

namespace FinalFormsApp
{
    public partial class FormPesan : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi konn = new Koneksi();
        public FormPesan()
        {
            InitializeComponent();

        }
        private void radioButtonHari_CheckedChanged(object sender, EventArgs e)
        {
          
        }
     

    }
}
