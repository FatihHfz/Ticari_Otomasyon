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
    public partial class frmAdmin : Form
    {
        private OleDbConnection connection = new OleDbConnection();

        public frmAdmin()
        {
            InitializeComponent();
            connection.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=Databasentp.accdb";
        }

        
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Turquoise;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aquamarine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "Select * from Admin where KullanıcıAdı='" + textBox1.Text + "' and Şifre='" + textBox2.Text +"'";
            OleDbDataReader reader = command.ExecuteReader();

          
            if(reader.Read())
            {
                Form1 fr = new Form1();
                fr.Show();
                this.Hide(); 
            }
          
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            connection.Close();

        }
    }
}
