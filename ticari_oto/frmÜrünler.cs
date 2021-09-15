using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ticari_oto
{
    public partial class frmÜrünler : Form
    {

        OleDbConnection veritabani_baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Databasentp.accdb");
        OleDbDataAdapter Veri_Adaptor;
        OleDbCommand Veri_Komutu;
        OleDbDataReader Veri_Oku;
        DataSet Veri_Seti;

        public frmÜrünler()
        {
            InitializeComponent();
        }
            void Tablo_veri_getir()
                 {
            Veri_Adaptor = new OleDbDataAdapter("Select * from Ürünler", veritabani_baglanti);
            Veri_Seti = new DataSet();
            veritabani_baglanti.Open();
            //veri okumak için:-----b
            Veri_Adaptor.Fill(Veri_Seti, "Ürünler");
            dataGridView1.DataSource = Veri_Seti.Tables["Ürünler"];
            veritabani_baglanti.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText="Insert into Ürünler (ÜrünAdı,Marka,Model,Yıl,Adet,AlışFiyatı,SatışFiyatı,Detay) values" +
            "('"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"','"+int.Parse((numericUpDown1.Value).ToString())+"','"+decimal.Parse(textBox6.Text)+"','"+decimal.Parse(textBox7.Text)+"','"+richTextBox1.Text+"')";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Ürün Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Tablo_veri_getir();
        }

        private void frmÜrünler_Load(object sender, EventArgs e)
        {
            Tablo_veri_getir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
             numericUpDown1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
             richTextBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Update Ürünler set ÜrünAdı ='"+textBox2.Text+"',Marka ='"+textBox3.Text+"',Model ='"+textBox4.Text +"',Yıl ='"+textBox5.Text+"'," +
                "Adet ='"+int.Parse((numericUpDown1.Value).ToString())+"',AlışFiyatı ='"+decimal.Parse(textBox6.Text)+"',SatışFiyatı ='"+decimal.Parse(textBox7.Text)+"',Detay ='"+richTextBox1.Text+"' where ID ="+textBox1.Text+"";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Ürün Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Tablo_veri_getir();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Delete from Ürünler where ID="+textBox1.Text+"";
            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Ürün SiLindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Tablo_veri_getir();
        }
    }
}
