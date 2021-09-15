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
    public partial class frmGider : Form
    {
        OleDbConnection veritabani_baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Databasentp.accdb");
        OleDbDataAdapter Veri_Adaptor;
        OleDbCommand Veri_Komutu;
        OleDbDataReader Veri_Oku;
        DataSet Veri_Seti;
        public frmGider()
        {
            InitializeComponent();
        }
        void Tablo_veri_getir()
        {
            Veri_Adaptor = new OleDbDataAdapter("Select * from Gider", veritabani_baglanti);
            Veri_Seti = new DataSet();
            veritabani_baglanti.Open();
            //veri okumak için:-----b
            Veri_Adaptor.Fill(Veri_Seti, "Gider");
            dataGridView1.DataSource = Veri_Seti.Tables["Gider"];
            veritabani_baglanti.Close();


        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //ay
            comboBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //yıl

            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            richTextBox1.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void frmGider_Load(object sender, EventArgs e)
        {
            Tablo_veri_getir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Insert into Gider (Ay,Yıl,Elektrik,Su,Doğalgaz,İnternet,Maaşlar,Ekstra,Notlar) values" +
            "('" + comboBox1.Text + "','" + comboBox2.Text + "','" + decimal.Parse(textBox2.Text) + "','" + decimal.Parse(textBox3.Text) + "','" + decimal.Parse(textBox4.Text) + "'," +
            "'" + decimal.Parse(textBox5.Text) + "','" + decimal.Parse(textBox6.Text) + "','" + decimal.Parse(textBox7.Text) + "','" + richTextBox1.Text + "')";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Gider Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Tablo_veri_getir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Delete from Gider where ID=" + textBox1.Text + "";
            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Gider SiLindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Tablo_veri_getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Update Gider set Ay ='" + comboBox1.Text + "',Yıl ='" + comboBox2.Text + "',Elektrik ='" + decimal.Parse(textBox2.Text) + "',Su ='" + decimal.Parse(textBox3.Text) + "'," +
                "Doğalgaz ='" + decimal.Parse(textBox4.Text) + "',İnternet ='" + decimal.Parse(textBox5.Text) + "',Maaşlar ='" + decimal.Parse(textBox6.Text) + "',Ekstra ='" + decimal.Parse(textBox7.Text) + "',Notlar ='" + richTextBox1.Text + "' where ID =" + textBox1.Text + "";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Gider Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Tablo_veri_getir();
        }
    }
}
