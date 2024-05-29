using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnternetCafe2
{
    internal class Veritabani
    {
        public static SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-K1VS8E0\sqlexpress;Initial Catalog=InternetCafe;Integrated Security=True;Pooling=False");

        public static DataTable Listele(DataGridView gridview)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("Select * From TGenelOzellikler", baglanti);
            DataTable dt = new DataTable();
            cmd.Fill(dt);

            gridview.DataSource = dt;
            return dt;
        }

        public static DataTable GenelListele(DataGridView gridview, string sorgu)
        {
            SqlDataAdapter cmd = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            cmd.Fill(dt);

            gridview.DataSource = dt;
            return dt;
        }

            public static DataTable ComboyaBosMasaGetir(ComboBox combo)
        {
            baglanti.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("Select * From TMasalar Where Durumu='BOS'", baglanti);
            DataTable dt = new DataTable();
            cmd.Fill(dt);

            combo.DataSource = dt;
            combo.DisplayMember = "Masalar";
            combo.ValueMember = "MasaID";
            baglanti.Close();
            return dt;
        }

         public static void EkleSilGuncelle(SqlCommand command, String sorgu)
        {
            baglanti.Open();
            command.Connection = baglanti;
            command.CommandText = sorgu;
            command.ExecuteNonQuery();
            baglanti.Close();
        }

        public static SqlDataReader ListViewdeGoster(ListView list)
        {
            list.Items.Clear(); 
            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select * From THareketler Where Tarih >= @Tarih ", baglanti);
            cmd2.Parameters.AddWithValue("@Tarih",DateTime.Parse(DateTime.Now.ToShortDateString()));
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = dr[0].ToString();
                item.SubItems.Add(dr[1].ToString());
                item.SubItems.Add(dr[2].ToString());
                item.SubItems.Add(dr[3].ToString());
                item.SubItems.Add(dr[4].ToString());
                item.SubItems.Add(dr[5].ToString());
                item.SubItems.Add(dr[6].ToString());
                list.Items.Add(item);

            }
            baglanti.Close();
            return dr;
        }


    }
}

