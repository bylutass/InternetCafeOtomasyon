using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternetCafe2
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Giris_Load(object sender, EventArgs e)
        {
                        
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciGirisi(txtKullaniciAdi, txtSifre);
            if (Kullanici.durum == true)
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.Show();
                this.Hide();
            }
            else if(Kullanici.durum == false)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
