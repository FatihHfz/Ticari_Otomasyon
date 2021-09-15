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
    public partial class frmFirmalar : Form
    {
        OleDbConnection veritabani_baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Databasentp.accdb");
        OleDbDataAdapter Veri_Adaptor;
        OleDbCommand Veri_Komutu;
        OleDbDataReader Veri_Oku;
        DataSet Veri_Seti;
        public frmFirmalar()
        {
            InitializeComponent();
        }
        void Tablo_veri_getir()
        {
            Veri_Adaptor = new OleDbDataAdapter("Select * from Firma", veritabani_baglanti);
            Veri_Seti = new DataSet();
            veritabani_baglanti.Open();
            //veri okumak için:-----b
            Veri_Adaptor.Fill(Veri_Seti, "Firma");
            dataGridView1.DataSource = Veri_Seti.Tables["Firma"];
            veritabani_baglanti.Close();


        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString(); //yetkiliTc
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString(); //tel1
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString(); //tel2


            textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString(); //mail

            maskedTextBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString(); //fax

            textBox5.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString(); //il
            textBox7.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString(); //ilçe
            textBox8.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString(); //vergidaire

            richTextBox2.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString(); //adres
        }

        private void frmFirmalar_Load(object sender, EventArgs e)
        {
            Tablo_veri_getir();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Delete from Firma where ID=" + textBox1.Text + "";
            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Firma SiLindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Tablo_veri_getir();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Insert into Firma (Ad,Yetkili,YetkiliAdSoyad,YetkiliTc,Telefon1,Telefon2,Mail,Fax,İl,İlçe,VergiDaire,Adres) values" +
            "('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + maskedTextBox3.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "'," +
            "'" + textBox6.Text + "','" + maskedTextBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + richTextBox2.Text + "')";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Firma Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Tablo_veri_getir();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Update Firma set Ad ='"+textBox2.Text+"',Yetkili ='"+textBox3.Text+"',YetkiliAdSoyad ='"+textBox4.Text+"',YetkiliTc ='"+maskedTextBox3.Text+"'," +
                "Telefon1 ='"+maskedTextBox1.Text +"',Telefon2='"+maskedTextBox2.Text+"',Mail ='"+textBox6.Text+"',Fax ='"+maskedTextBox4.Text+"',İl ='"+textBox5.Text+"',İlçe ='"+textBox7.Text+"'," +
                "VergiDaire ='"+textBox8.Text+"',Adres ='"+richTextBox2.Text+"' Where ID = "+textBox1.Text+"";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Firma Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Tablo_veri_getir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
