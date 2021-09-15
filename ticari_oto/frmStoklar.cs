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
    public partial class frmStoklar : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        
        public frmStoklar()
        {
            InitializeComponent();
            connection.ConnectionString = "Provider=Microsoft.ACE.OleDb.12.0; Data Source=Databasentp.accdb";
        }
       

        private void frmStoklar_Load(object sender, EventArgs e)
        {
            
                connection.Open();
                OleDbCommand command = new OleDbCommand("select ÜrünAdı,Adet from Ürünler");
                command.Connection = connection;
                
               

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


                connection.Close();
        

        }
       
       
        private void frmStoklar_Load_1(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("select ÜrünAdı,Adet from Ürünler");
            command.Connection = connection;



            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Series1"].Points.AddXY(reader["ÜrünAdı"].ToString(), reader["Adet"].ToString());
            }
            


            connection.Close();

        }

      
    }
}

