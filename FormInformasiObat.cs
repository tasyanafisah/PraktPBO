using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apotek_PBO
{

    public partial class FormInformasiObat : Form
    {
        public FormInformasiObat()
        {
            InitializeComponent();
        }

        private void btnTambahObat_Click(object sender, EventArgs e)
        {
            FormTambahObat form2 = new FormTambahObat();
            form2.Show();
        }

        private void FormInformasiObat_Load(object sender, EventArgs e)
        {

        }
    }
}
