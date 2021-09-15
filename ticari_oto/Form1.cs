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
    public partial class Form1 : Form
    {


        public object secilenform;
        frmÜrünler frm = new frmÜrünler();
        frmMüsteriler frm2 = new frmMüsteriler();
        frmFirmalar frm3 = new frmFirmalar();
        frmPersonel frm4 = new frmPersonel();
        frmGider frm5 = new frmGider();
        frmStoklar frm6 = new frmStoklar();
        frmAyarlar frm7 = new frmAyarlar();


        public Form1()
        {
            InitializeComponent();
        }

        frmÜrünler fr;
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriler fc2 = Application.OpenForms["frmMüsteriler"] != null ? (frmMüsteriler) Application.OpenForms["frmMüsteriler"] : null;
            if (fc2 != null)
            {
                 fc2.Close();
            }
            frmFirmalar fc3 = Application.OpenForms["frmFirmalar"] != null ? (frmFirmalar)Application.OpenForms["frmFirmalar"] : null;
            if (fc3 != null)
            {
                fc3.Close();
            }
            frmPersonel fc4 = Application.OpenForms["frmPersonel"] != null ? (frmPersonel)Application.OpenForms["frmPersonel"] : null;
            if (fc4 != null)
            {
                fc4.Close();
            }
            frmGider fc5 = Application.OpenForms["frmGider"] != null ? (frmGider)Application.OpenForms["frmGider"] : null;
            if (fc5 != null)
            {
                fc5.Close();
            }
            frmStoklar fc6 = Application.OpenForms["frmStoklar"] != null ? (frmStoklar)Application.OpenForms["frmStoklar"] : null;
            if (fc6 != null)
            {
                fc6.Close();
            }
            frmAyarlar fc7 = Application.OpenForms["frmAyarlar"] != null ? (frmAyarlar)Application.OpenForms["frmAyarlar"] : null;
            if (fc7 != null)
            {
                fc7.Close();
            }

            if (fr == null)
            {
                fr = new frmÜrünler();
                secilenform = fr;
                fr.MdiParent = this;
                fr.FormBorderStyle = FormBorderStyle.None;
                fr.FormClosed += new FormClosedEventHandler(Fr_FormClosed);
                fr.Show();
            }
            else
                fr.Activate();
        }

        private void Fr_FormClosed(object sender, FormClosedEventArgs e)
        {
            fr = null;
          //  throw new NotImplementedException();
        }

        frmMüsteriler fr2; 
        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmÜrünler fc1 = Application.OpenForms["frmÜrünler"] != null ? (frmÜrünler)Application.OpenForms["frmÜrünler"] : null;
            if (fc1 != null)
            {
                fc1.Close();
            }
            frmFirmalar fc3 = Application.OpenForms["frmFirmalar"] != null ? (frmFirmalar)Application.OpenForms["frmFirmalar"] : null;
            if (fc3 != null)
            {
                fc3.Close();
            }
            frmPersonel fc4 = Application.OpenForms["frmPersonel"] != null ? (frmPersonel)Application.OpenForms["frmPersonel"] : null;
            if (fc4 != null)
            {
                fc4.Close();
            }
            frmGider fc5 = Application.OpenForms["frmGider"] != null ? (frmGider)Application.OpenForms["frmGider"] : null;
            if (fc5 != null)
            {
                fc5.Close();
            }
            frmStoklar fc6 = Application.OpenForms["frmStoklar"] != null ? (frmStoklar)Application.OpenForms["frmStoklar"] : null;
            if (fc6 != null)
            {
                fc6.Close();
            }
            frmAyarlar fc7 = Application.OpenForms["frmAyarlar"] != null ? (frmAyarlar)Application.OpenForms["frmAyarlar"] : null;
            if (fc7 != null)
            {
                fc7.Close();
            }
           

            if (fr2 == null)
            {
                fr2 = new frmMüsteriler();
                secilenform = fr2;
                fr2.MdiParent = this;
                fr2.FormBorderStyle = FormBorderStyle.None;
                fr2.FormClosed += new FormClosedEventHandler(Fr2_FormClosed);
                fr2.Show();
            }
            else
                fr2.Activate();

        }

        private void Fr2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fr2 = null;
            //throw new NotImplementedException();
        }

        frmFirmalar fr3;
        private void firmalarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmMüsteriler fc2 = Application.OpenForms["frmMüsteriler"] != null ? (frmMüsteriler)Application.OpenForms["frmMüsteriler"] : null;
            if (fc2 != null)
            {
                fc2.Close();
            }
            frmÜrünler fc1 = Application.OpenForms["frmÜrünler"] != null ? (frmÜrünler)Application.OpenForms["frmÜrünler"] : null;
            if (fc1 != null)
            {
                fc1.Close();
            }
            frmPersonel fc4 = Application.OpenForms["frmPersonel"] != null ? (frmPersonel)Application.OpenForms["frmPersonel"] : null;
            if (fc4 != null)
            {
                fc4.Close();
            }
            frmGider fc5 = Application.OpenForms["frmGider"] != null ? (frmGider)Application.OpenForms["frmGider"] : null;
            if (fc5 != null)
            {
                fc5.Close();
            }
            frmStoklar fc6 = Application.OpenForms["frmStoklar"] != null ? (frmStoklar)Application.OpenForms["frmStoklar"] : null;
            if (fc6 != null)
            {
                fc6.Close();
            }
            frmAyarlar fc7 = Application.OpenForms["frmAyarlar"] != null ? (frmAyarlar)Application.OpenForms["frmAyarlar"] : null;
            if (fc7 != null)
            {
                fc7.Close();
            }


            if (fr3 == null)
            {
                fr3 = new frmFirmalar();
                secilenform = fr3;
                fr3.MdiParent = this;
                fr3.FormBorderStyle = FormBorderStyle.None;
                fr3.FormClosed += new FormClosedEventHandler(Fr3_FormClosed);
                fr3.Show();
            }
            else
                fr3.Activate();

        }

        private void Fr3_FormClosed(object sender, FormClosedEventArgs e)
        {
            fr3 = null;
           // throw new NotImplementedException();
        }

        frmPersonel fr4;
        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriler fc2 = Application.OpenForms["frmMüsteriler"] != null ? (frmMüsteriler)Application.OpenForms["frmMüsteriler"] : null;
            if (fc2 != null)
            {
                fc2.Close();
            }
            frmFirmalar fc3 = Application.OpenForms["frmFirmalar"] != null ? (frmFirmalar)Application.OpenForms["frmFirmalar"] : null;
            if (fc3 != null)
            {
                fc3.Close();
            }
            frmÜrünler fc1 = Application.OpenForms["frmÜrünler"] != null ? (frmÜrünler)Application.OpenForms["frmÜrünler"] : null;
            if (fc1 != null)
            {
                fc1.Close();
            }
            frmGider fc5 = Application.OpenForms["frmGider"] != null ? (frmGider)Application.OpenForms["frmGider"] : null;
            if (fc5 != null)
            {
                fc5.Close();
            }
            frmStoklar fc6 = Application.OpenForms["frmStoklar"] != null ? (frmStoklar)Application.OpenForms["frmStoklar"] : null;
            if (fc6 != null)
            {
                fc6.Close();
            }
            frmAyarlar fc7 = Application.OpenForms["frmAyarlar"] != null ? (frmAyarlar)Application.OpenForms["frmAyarlar"] : null;
            if (fc7 != null)
            {
                fc7.Close();
            }
            if (fr4 == null)
            {
                fr4 = new frmPersonel();
                secilenform = fr4;
                fr4.MdiParent = this;
                fr4.FormBorderStyle = FormBorderStyle.None;
                fr4.FormClosed += new FormClosedEventHandler(Fr4_FormClosed);
                fr4.Show();
            }
        }

        private void Fr4_FormClosed(object sender, FormClosedEventArgs e)
        {
            fr4 = null;
            //throw new NotImplementedException();
        }

        frmGider fr5;
        private void giderlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriler fc2 = Application.OpenForms["frmMüsteriler"] != null ? (frmMüsteriler)Application.OpenForms["frmMüsteriler"] : null;
            if (fc2 != null)
            {
                fc2.Close();
            }
            frmFirmalar fc3 = Application.OpenForms["frmFirmalar"] != null ? (frmFirmalar)Application.OpenForms["frmFirmalar"] : null;
            if (fc3 != null)
            {
                fc3.Close();
            }
            frmPersonel fc4 = Application.OpenForms["frmPersonel"] != null ? (frmPersonel)Application.OpenForms["frmPersonel"] : null;
            if (fc4 != null)
            {
                fc4.Close();
            }
            frmÜrünler fc1 = Application.OpenForms["frmÜrünler"] != null ? (frmÜrünler)Application.OpenForms["frmÜrünler"] : null;
            if (fc1 != null)
            {
                fc1.Close();
            }
            frmStoklar fc6 = Application.OpenForms["frmStoklar"] != null ? (frmStoklar)Application.OpenForms["frmStoklar"] : null;
            if (fc6 != null)
            {
                fc6.Close();
            }
            frmAyarlar fc7 = Application.OpenForms["frmAyarlar"] != null ? (frmAyarlar)Application.OpenForms["frmAyarlar"] : null;
            if (fc7 != null)
            {
                fc7.Close();
            }
            if (fr5 == null)
            {
                fr5 = new frmGider();
                secilenform = fr5;
                fr5.MdiParent = this;
                fr5.FormBorderStyle = FormBorderStyle.None;
                fr5.FormClosed += new FormClosedEventHandler(Fr5_FormClosed);
                fr5.Show();
            }
            else
                fr5.Activate();

        }
        
        private void Fr5_FormClosed(object sender, FormClosedEventArgs e)
        {
            fr5 = null;
            //throw new NotImplementedException();
        }
        
        frmStoklar fr6;
        private void stoklarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriler fc2 = Application.OpenForms["frmMüsteriler"] != null ? (frmMüsteriler)Application.OpenForms["frmMüsteriler"] : null;
            if (fc2 != null)
            {
                fc2.Close();
            }
            frmFirmalar fc3 = Application.OpenForms["frmFirmalar"] != null ? (frmFirmalar)Application.OpenForms["frmFirmalar"] : null;
            if (fc3 != null)
            {
                fc3.Close();
            }
            frmPersonel fc4 = Application.OpenForms["frmPersonel"] != null ? (frmPersonel)Application.OpenForms["frmPersonel"] : null;
            if (fc4 != null)
            {
                fc4.Close();
            }
            frmGider fc5 = Application.OpenForms["frmGider"] != null ? (frmGider)Application.OpenForms["frmGider"] : null;
            if (fc5 != null)
            {
                fc5.Close();
            }
            frmÜrünler fc1 = Application.OpenForms["frmÜrünler"] != null ? (frmÜrünler)Application.OpenForms["frmÜrünler"] : null;
            if (fc1 != null)
            {
                fc1.Close();
            }
            frmAyarlar fc7 = Application.OpenForms["frmAyarlar"] != null ? (frmAyarlar)Application.OpenForms["frmAyarlar"] : null;
            if (fc7 != null)
            {
                fc7.Close();
            }
           
            if (fr6 == null)
            {
                fr6 = new frmStoklar();
                secilenform = fr6;
                fr6.MdiParent = this;
                fr6.FormBorderStyle = FormBorderStyle.None;
                fr6.FormClosed += new FormClosedEventHandler(Fr6_FormClosed); ;
                fr6.Show();
            }
            else
                fr6.Activate();
        }

        private void Fr6_FormClosed(object sender, FormClosedEventArgs e)
        {
            fr6 = null;
          //  throw new NotImplementedException();
        }

        frmAyarlar fr7;
        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriler fc2 = Application.OpenForms["frmMüsteriler"] != null ? (frmMüsteriler)Application.OpenForms["frmMüsteriler"] : null;
            if (fc2 != null)
            {
                fc2.Close();
            }
            frmFirmalar fc3 = Application.OpenForms["frmFirmalar"] != null ? (frmFirmalar)Application.OpenForms["frmFirmalar"] : null;
            if (fc3 != null)
            {
                fc3.Close();
            }
            frmPersonel fc4 = Application.OpenForms["frmPersonel"] != null ? (frmPersonel)Application.OpenForms["frmPersonel"] : null;
            if (fc4 != null)
            {
                fc4.Close();
            }
            frmGider fc5 = Application.OpenForms["frmGider"] != null ? (frmGider)Application.OpenForms["frmGider"] : null;
            if (fc5 != null)
            {
                fc5.Close();
            }
            frmStoklar fc6 = Application.OpenForms["frmStoklar"] != null ? (frmStoklar)Application.OpenForms["frmStoklar"] : null;
            if (fc6 != null)
            {
                fc6.Close();
            }
            frmÜrünler fc1 = Application.OpenForms["frmÜrünler"] != null ? (frmÜrünler)Application.OpenForms["frmÜrünler"] : null;
            if (fc1 != null)
            {
                fc1.Close();
            }
            
            if (fr7 == null)
            {
                fr7 = new frmAyarlar();
                secilenform = fr7;
                fr7.MdiParent = this;
                fr7.FormBorderStyle = FormBorderStyle.None;
                fr7.FormClosed += new FormClosedEventHandler(Fr7_FormClosed); ;
                fr7.Show();
            }
            else
                fr7.Activate();
        }

        private void Fr7_FormClosed(object sender, FormClosedEventArgs e)
        {
            fr7 = null;
           // throw new NotImplementedException();
        }

        private void anaSayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriler fc2 = Application.OpenForms["frmMüsteriler"] != null ? (frmMüsteriler)Application.OpenForms["frmMüsteriler"] : null;
            if (fc2 != null)
            {
                fc2.Close();
            }
            frmFirmalar fc3 = Application.OpenForms["frmFirmalar"] != null ? (frmFirmalar)Application.OpenForms["frmFirmalar"] : null;
            if (fc3 != null)
            {
                fc3.Close();
            }
            frmPersonel fc4 = Application.OpenForms["frmPersonel"] != null ? (frmPersonel)Application.OpenForms["frmPersonel"] : null;
            if (fc4 != null)
            {
                fc4.Close();
            }
            frmGider fc5 = Application.OpenForms["frmGider"] != null ? (frmGider)Application.OpenForms["frmGider"] : null;
            if (fc5 != null)
            {
                fc5.Close();
            }
            frmStoklar fc6 = Application.OpenForms["frmStoklar"] != null ? (frmStoklar)Application.OpenForms["frmStoklar"] : null;
            if (fc6 != null)
            {
                fc6.Close();
            }
            frmÜrünler fc1 = Application.OpenForms["frmÜrünler"] != null ? (frmÜrünler)Application.OpenForms["frmÜrünler"] : null;
            if (fc1 != null)
            {
                fc1.Close();
            }
            frmAyarlar fc7 = Application.OpenForms["frmAyarlar"] != null ? (frmAyarlar)Application.OpenForms["frmAyarlar"] : null;
            if (fc7 != null)
            {
                fc7.Close();
            }

        }

    }
}
