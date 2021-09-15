using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticari_oto
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        int i=1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 10;
            label5.Refresh();
            if(i==4)
            {
                i = 1;
                label5.Text = ".";

            }
           else if (i == 1)
            {
                i = i+1;
                label5.Text = "..";

            }
            else if (i == 2)
            {
                i = i + 2;
                label5.Text = "...";

            }
            else if (i == 3)
            {
                i = i + 2;
                label5.Text = "...";

            }

            if (panel2.Width >=682)
            {
                timer1.Stop();
                frmAdmin form = new frmAdmin();
                form.Show();
                this.Hide();
            }
              
        }
    }
}
