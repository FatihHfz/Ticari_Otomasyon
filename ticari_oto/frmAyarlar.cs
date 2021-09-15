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
    public partial class frmAyarlar : Form
    {
        OleDbConnection veritabani_baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0; Data Source=Databasentp.accdb");
        OleDbDataAdapter Veri_Adaptor;
        OleDbCommand Veri_Komutu;
        OleDbDataReader Veri_Oku;
        DataSet Veri_Seti;

        private OleDbConnection connection = new OleDbConnection();
        public frmAyarlar()
        {
            InitializeComponent();
            
        }
        void Tablo_veri_getir()
        {
            Veri_Adaptor = new OleDbDataAdapter("Select * from Admin", veritabani_baglanti);
            Veri_Seti = new DataSet();
            veritabani_baglanti.Open();
            //veri okumak için:-----b
            Veri_Adaptor.Fill(Veri_Seti, "Admin");
            dataGridView1.DataSource = Veri_Seti.Tables["Admin"];
            veritabani_baglanti.Close();
        }

        private void frmAyarlar_Load(object sender, EventArgs e)
        {
            Tablo_veri_getir();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Update Admin set KullanıcıAdı ='"+textBox1.Text+ "',Şifre ='" + textBox2.Text + "' where Kimlik =" + textBox3.Text + "";
               

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Tablo_veri_getir();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ekleme
            
            Veri_Komutu = new OleDbCommand();
            veritabani_baglanti.Open();
            Veri_Komutu.Connection = veritabani_baglanti;
            Veri_Komutu.CommandText = "Insert into Admin (KullanıcıAdı,Şifre) values" +
            "('" + textBox1.Text + "','" + textBox2.Text + "')";
            //'" + decimal.Parse(textBox6.Text) + "','" + decimal.Parse(textBox7.Text) + "','" + richTextBox1.Text + "')";

            Veri_Komutu.ExecuteNonQuery();
            veritabani_baglanti.Close();
            MessageBox.Show("Kullanıcı Sisteme Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Tablo_veri_getir();
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
