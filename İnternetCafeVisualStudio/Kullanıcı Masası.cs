using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternetCafe2
{
    public partial class frmKullaniciMasasi : Form
    {
        public frmKullaniciMasasi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.ShowDialog();
        }
    }
}
