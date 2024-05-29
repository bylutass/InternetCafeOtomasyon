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
using System.Data.Sql;

namespace İnternetCafe2
{
    public partial class AnaSayfa : Form
    {
        Button btn;


        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        RadioButton radio1;
        private void RadioButtonSecim(object sender, EventArgs e)
        {
            radio1 = sender as RadioButton;
        }
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            this.tSaatlikUcretTableAdapter1.Fill(this.internetCafeDataSet4.TSaatlikUcret);


            radioButtonSuresiz.Checked = true;
            Yenileme();
            comboBosMasalar.Text = "";
            timer1.Start();

            foreach (Control ct in Controls)
            {
                if (ct is Button)
                {

                    Veritabani.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Select * From TMasalar", Veritabani.baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["durumu"].ToString() == "BOS" && dr["Masalar"].ToString() == ct.Text)
                        {
                            ct.BackColor = Color.Red;
                        }
                        if (dr["durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == ct.Text)
                        {
                            ct.BackColor = Color.LightGreen;
                        }
                    }
                    Veritabani.baglanti.Close();

                }
            }
        }
        public void Yenileme()
        {
            Veritabani.ListViewdeGoster(listView1);
            Veritabani.ComboyaBosMasaGetir(comboBosMasalar);
            Veritabani.Listele(dataGridView1);

            foreach (Control ct in Controls)
            {
                if (ct is Button)
                {

                    Veritabani.baglanti.Open();
                    SqlCommand cmd = new SqlCommand("Select * From TMasalar", Veritabani.baglanti);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["durumu"].ToString() == "BOS" && dr["Masalar"].ToString() == ct.Text)
                        {
                            ct.BackColor = Color.Red;
                        }
                        if (dr["durumu"].ToString() == "DOLU" && dr["Masalar"].ToString() == ct.Text)
                        {
                            ct.BackColor = Color.LightGreen;
                        }
                    }
                    Veritabani.baglanti.Close();

                }
            }

        }

        private void Secim(object sender, MouseEventArgs e)
        {
            btn = sender as Button;
            if (btn.BackColor == Color.LightGreen)
            {
                masaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
            }
            if (btn.BackColor == Color.Red)
            {
                masaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
            }

        }

        private void radioButtonSuresiz_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonMasaAc_Click(object sender, EventArgs e)
        {

            if (comboBosMasalar.Text == "")
            {
                MessageBox.Show("Lütfen masa seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBosMasalar.Text != "")
            {
                if (Kullanici.KullaniciID == 1)
                {


                    string sqlsorgu = "insert into TGenelOzellikler(MasaID, Masa, AcilisTuru, Baslangic, Tarih) values('" + comboBosMasalar.Text.Substring(5) + "', '" + comboBosMasalar.Text + "'" +
                    ",'" + radio1.Text + "', @Baslangic, @Tarih)";
                    SqlCommand komut = new SqlCommand();
                    komut.Parameters.AddWithValue("@Baslangic", DateTime.Parse(DateTime.Now.ToString()));
                    komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));
                    Veritabani.EkleSilGuncelle(komut, sqlsorgu);
                    MessageBox.Show(comboBosMasalar.Text.Substring(5) + " nolu masa açıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Yenileme();
                    radioButtonSuresiz.Checked = true;


                }
                else
                {
                    MessageBox.Show("Bunun için yetkiniz yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }



        private void button33_Click(object sender, EventArgs e)
        {

            if (Kullanici.KullaniciID == 1)
            {
                int GenelOzellikID = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
                int MasaID = int.Parse(dataGridView1.CurrentRow.Cells["MasaID_"].Value.ToString());
                String sql = "Update TGenelOzellikler set MasaID = '" + int.Parse(comboBosMasalar.Text.Substring(5)) + "', Masa = '" + comboBosMasalar.Text + "' where GenelOzelliklerID = '" + GenelOzellikID + "'";

                SqlCommand cmd = new SqlCommand();
                Veritabani.EkleSilGuncelle(cmd, sql);

                String sql2 = "update TMasalar set Durumu='BOS' where MasaID='" + MasaID + "'";
                SqlCommand cmd2 = new SqlCommand();
                Veritabani.EkleSilGuncelle(cmd2, sql2);

                String sql3 = "update TMasalar set Durumu='DOLU' where MasaID='" + int.Parse(comboBosMasalar.Text.Substring(5)) + "'";
                SqlCommand cmd3 = new SqlCommand();
                Veritabani.EkleSilGuncelle(cmd3, sql3);
                Yenileme();
                MessageBox.Show("Yenileme işlemi başarılı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                MessageBox.Show("Bunun için yetkiniz yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboSureler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Sure"].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString() != "Süresiz")
                    {
                        double sure = double.Parse(dataGridView1.Rows[i].Cells["Sure"].Value.ToString()) * 60;
                        double acilisturu = double.Parse(dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString());
                        if (acilisturu - sure <= 5.0)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        
        private void Istekler()
        {
            String sqlsorgu = "insert into THareketler(KullaniciID, MasaID, Masa, IstekTuru, Aciklama, Tarih) values(" +
                "'" + Kullanici.KullaniciID + "' , '" + btn.Text.Substring(5) + "' , '" + btn.Text + "' , '" + istek + "' , ' Yapilmadi ', @Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));
            Veritabani.EkleSilGuncelle(komut, sqlsorgu);
            Veritabani.ListViewdeGoster(listView1);
        }

        String istek = "";
        private void yöneticiÇağırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            İtem = sender as ToolStripMenuItem;
            istek = "Yöneticiyi Çağırıyor";
            Istekler();

        }

        private void masaAçmaİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        ToolStripMenuItem İtem;
        private void SureIstek(object sender, EventArgs e)
        {
            İtem = sender as ToolStripMenuItem;
            istek = İtem.Text + "masa açma isteği gönderdi.";
            Istekler();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac > 29)
            {
                if (comboSaatlikUcret.Text != "")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DateTime BitisTarihi = DateTime.Now;
                        DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.Rows[i].Cells["BaslamaSaati"].Value.ToString());
                        TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                        double saatfarki2 = saatfarki.TotalHours;
                        dataGridView1.Rows[i].Cells["Sure"].Value = saatfarki2.ToString();
                        double toplamTutar = saatfarki2 * double.Parse(comboSaatlikUcret.Text);
                        dataGridView1.Rows[i].Cells["Tutar"].Value = toplamTutar.ToString();
                        dataGridView1.Rows[i].Cells["BitisSaati"].Value = BitisTarihi;
                    }


                }
                if (comboSaatlikUcret.Text == "")
                {
                    MessageBox.Show("Bir Ücret Seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Kullanici.KullaniciID == 1)
            {
                if (e.ColumnIndex == dataGridView1.Columns["Hesapla"].Index)
                {
                    if (comboSaatlikUcret.Text != "")
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            DateTime BitisTarihi = DateTime.Now;
                            DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.Rows[i].Cells["BaslamaSaati"].Value.ToString());
                            TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                            double saatfarki2 = saatfarki.TotalHours;
                            dataGridView1.Rows[i].Cells["Sure"].Value = saatfarki2.ToString("0.00");
                            double toplamTutar = saatfarki2 * double.Parse(comboSaatlikUcret.Text);
                            dataGridView1.Rows[i].Cells["Tutar"].Value = toplamTutar.ToString("0.00");
                            dataGridView1.Rows[i].Cells["BitisSaati"].Value = BitisTarihi;
                        }


                    }
                    if (comboSaatlikUcret.Text == "")
                    {
                        MessageBox.Show("Bir Ücret Seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (e.ColumnIndex == dataGridView1.Columns["MasaKapat"].Index)
                {
                    if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value != null)
                    {
                        MasaKapat masaKapat = new MasaKapat();
                        masaKapat.TxtID_.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                        masaKapat.TxtMasaID_.Text = dataGridView1.CurrentRow.Cells["MasaID_"].Value.ToString();
                        masaKapat.TxtMasa_.Text = dataGridView1.CurrentRow.Cells["Masa_"].Value.ToString();
                        masaKapat.TxtAcilisTuru_.Text = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
                        masaKapat.TxtBaslamaSaati_.Text = dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString();
                        masaKapat.TxtBitisSaati_.Text = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                        masaKapat.TxtTutar_.Text = comboSaatlikUcret.Text;
                        masaKapat.TxtSuree.Text = dataGridView1.CurrentRow.Cells["Sure"].Value.ToString();
                        masaKapat.TxtTutar_.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                        masaKapat.TxtTarih_.Text = dataGridView1.CurrentRow.Cells["Tarih_"].Value.ToString();
                        masaKapat.ShowDialog();
                    }
                    else if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value == null)
                    {
                        MessageBox.Show("Önce hesaplama yapılmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                } 
            }
            else
            {
                MessageBox.Show("Bunun için yetkiniz yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Sure"].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString() != "Süresiz")
                    {
                        double sure = double.Parse(dataGridView1.Rows[i].Cells["Sure"].Value.ToString()) * 60;
                        double acilisturu = double.Parse(dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString());
                        if (acilisturu - sure <= 5)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void AnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin misiniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {
                Application.Run();
            }
        }
    }
}

