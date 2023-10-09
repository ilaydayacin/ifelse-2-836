using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_2.örnek_836
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbMavi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMavi.Checked)
            {
                this.BackColor = Color.Blue; 
                this.ForeColor=Color.Black;
                lblRenk.Text = "Hangi renk yapıldı: Mavi";
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }

        private void cbKirmizi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKirmizi.Checked)
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.Yellow;
                lblRenk.Text = "Hangi renk yapıldı: Kırmızı";
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }

        private void cbMor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMor.Checked)
            {
                this.BackColor = Color.Purple;
                this.ForeColor = Color.Black;
                lblRenk.Text = "Hangi renk yapıldı: Mor";
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }

        private void cbPembe_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPembe.Checked)
            {
                this.BackColor = Color.DeepPink;
                this.ForeColor = Color.Black;
                lblRenk.Text = "Hangi renk yapıldı: Pembe";
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }

        private void cbSiyah_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSiyah.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.Green;
                lblRenk.Text = "Hangi renk yapıldı: Mavi";
            }
            else
            {
                this.BackColor = Color.WhiteSmoke;
            }
        }
    }
}
