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
    public partial class frmMüsteriler : Form
    {
        OleDbConnection veritabani_baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Databasentp.accdb");
        OleDbDataAdapter Veri_Adaptor;
        OleDbCommand Veri_Komutu;
        OleDbDataReader Veri_Oku;
        DataSet Veri_Seti;

        public frmMüsteriler()
        {
            InitializeComponent();
        }
        void Tablo_veri_getir()
        {
            Veri_Adaptor = new OleDbDataAdapter("Select * from Müşteriler", veritabani_baglanti);
            Veri_Seti = new DataSet();
            veritabani_baglanti.Open();
            //veri okumak için:-----b
            Veri_Adaptor.Fill(Veri_Seti, "Müşteriler");
            dataGridView1.DataSource = Veri_Seti.Tables["Müşteriler"];
            veritabani_baglanti.Close();


        }

        private void frmMüsteriler_Load(object sender, EventArgs e)
        {
            Tablo_veri_getir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();

            richTextBox1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Insert into Müşteriler (Ad,Soyad,Telefon1,Telefon2,TC,Mail,İl,İlçe,VergiDairesi,Adres) values" +
            "('" + textBox2.Text + "','" + textBox3.Text + "','" + maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox3.Text + "'," +
            "'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + richTextBox1.Text + "')";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Müşteri Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Tablo_veri_getir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Delete from Müşteriler where ID=" + textBox1.Text + "";
            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Müşteri SiLindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            Tablo_veri_getir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Update Müşteriler set Ad ='"+textBox2.Text+"',Soyad ='"+textBox3.Text+"',Telefon1 ='"+maskedTextBox1+"',Telefon2 ='"+maskedTextBox2+"',"+
                "TC ='"+maskedTextBox3+"',Mail ='"+textBox4.Text+"',İl ='"+textBox5.Text +"',İlçe ='"+textBox6.Text+"',VergiDairesi ='"+textBox7.Text+"',Adres ='"+richTextBox1.Text+"' Where ID ="+textBox1.Text+"";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Müşteri Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           /* foreach(Control item in this.Controls )
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
           */

            Tablo_veri_getir();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}