using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5426Etut_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYarisiBaslat_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)//timer'ım çalışıyorsa
            {
                timer1.Stop();//durdur
            }
            else//timer'ım çalışmıyorsa
            {
                timer1.Start();//başlat
            }
        }
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pcbBirinciAt.Left += rnd.Next(5,16);
            pcbIkinciAt.Left += rnd.Next(5,16);
            pcbUcuncuAt.Left += rnd.Next(5,16);

            if (pcbBirinciAt.Left > pcbIkinciAt.Left && pcbBirinciAt.Left > pcbUcuncuAt.Left)
            {
                this.Text = "Rüzgar önde götürüyor...";
            }
            else if (pcbIkinciAt.Left > pcbBirinciAt.Left && pcbIkinciAt.Left > pcbUcuncuAt.Left)
            {
                this.Text = "Kara Şimşek önde götürüyor...";
            }
            else if (pcbUcuncuAt.Left > pcbBirinciAt.Left && pcbUcuncuAt.Left > pcbIkinciAt.Left)
            {
                this.Text = "Şahbatur önde götürüyor...";
            }
            
            if (pcbBirinciAt.Left + pcbBirinciAt.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı Rüzgar Kazandı !!!");
                pcbBirinciAt.Enabled = pcbIkinciAt.Enabled = pcbUcuncuAt.Enabled = false;
            }
            else if (pcbIkinciAt.Left + pcbIkinciAt.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı Kara Şimşek Kazandı !!!");
                pcbBirinciAt.Enabled = pcbIkinciAt.Enabled = pcbUcuncuAt.Enabled = false;
            }
            else if (pcbUcuncuAt.Left + pcbUcuncuAt.Width >= lblFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Yarışı Şahbatur Kazandı !!!");
                pcbBirinciAt.Enabled = pcbIkinciAt.Enabled = pcbUcuncuAt.Enabled = false;
            }
        }

        private void btnYarisiSifirla_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            pcbBirinciAt.Left = 10;
            pcbIkinciAt.Left = 10;
            pcbUcuncuAt.Left = 10;
            this.Text = "";
            pcbBirinciAt.Enabled = pcbIkinciAt.Enabled = pcbUcuncuAt.Enabled = true;
        }

        private void btnRuzgarGaz_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            pcbBirinciAt.Left += 15;
        }

        private void btnKaraSimsekGaz_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            pcbIkinciAt.Left += 15;
        }

        private void btnSahbaturGaz_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled)
            pcbUcuncuAt.Left += 15;
        }
    }
}
