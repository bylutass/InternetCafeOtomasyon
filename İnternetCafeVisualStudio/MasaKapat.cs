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

namespace İnternetCafe2
{
    public partial class MasaKapat : Form
    {
        public MasaKapat()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sorgu = "insert into TUcret(KullaniciID, MasaID, AcilisTuru, BaslangicSaati, BitisSaati,Sure,Tutar,Aciklama,Tarih) " +
            //    "values('"+ Kullanici.KullaniciID +"', '"+ int.Parse(TxtMasaID_.Text) +"', '"+ TxtAcilisTuru_.Text +"', @BaslangicSaati, @BitisSaati, @Sure, @Tutar, 'Yapılmadı', @Tarih)";
            //SqlCommand cmd = new SqlCommand();
            //cmd.Parameters.AddWithValue("@Baslangic", DateTime.Parse(TxtBaslamaSaati_.Text));
            //cmd.Parameters.AddWithValue("@Bitis", DateTime.Parse(TxtBitisSaati_.Text));
            //cmd.Parameters.AddWithValue("@Sure", Decimal.Parse(TxtSuree.Text));
            //cmd.Parameters.AddWithValue("@Tutar", Decimal.Parse(TxtTutar_.Text));
            //cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(TxtTarih_.Text));
            //Veritabani.EkleSilGuncelle(cmd, sorgu);
            string sorgu = "update TMasalar set Durumu = 'BOS' where MasaID = '" + TxtMasaID_.Text + "'";
            SqlCommand cmd = new SqlCommand();
            Veritabani.EkleSilGuncelle(cmd, sorgu);
            string sorgu2 = "delete from TGenelOzellikler where GenelOzelliklerID = '" + TxtID_.Text + "'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.EkleSilGuncelle(cmd2, sorgu2);
            this.Close();
            AnaSayfa anasayfa = (AnaSayfa)Application.OpenForms["anasayfa"];
            anasayfa.Yenileme();


        }

        private void MasaNumarası_TextChanged(object sender, EventArgs e)
        {

        }

        private void MasaKapat_Load(object sender, EventArgs e)
        {

        }
    }
}
