using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgrammingProject
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        public int sayac = 0;
        public int second = 60;
        public int minutes = 1;
        public void button1_Click(object sender, EventArgs e)
        {
            ParaCekme paraCekme = new ParaCekme();
            paraCekme.ShowDialog();
            
        }

        public void Menu_Load(object sender, EventArgs e)
        {
            timer6.Interval = 1000;
            timer6.Enabled = true;
            timer6.Start();
            labelName.Visible = true;
            labelSurname.Visible = true;
            label1.Visible = true;
            labelName.Text = Giris.ad;
            labelSurname.Text = Giris.soyad;   
        }

        public void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            ParaYatirma paraYatirma = new ParaYatirma();
            paraYatirma.ShowDialog();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            Havale havale = new Havale();
            havale.ShowDialog();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            BilgiGuncelleme bilgiGuncelleme = new BilgiGuncelleme();
            bilgiGuncelleme.ShowDialog();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            second = second - 1;
            lblSecond.Text = Convert.ToString(second);
            lblMinute.Text = Convert.ToString(minutes);
            if (second == 0)
            {
                minutes = minutes - 1;
                second = 60;
                second = second - 1;
                lblSecond.Text = Convert.ToString(minutes);
            }
            if (minutes == -1)
            {
                timer6.Stop();
                lblSecond.Text = "00";
                lblMinute.Text = "00";
                MessageBox.Show("Süre Boyunca İşlem Yapmadığınız İçin Sistem Kapanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Application.Exit();
                
            }
        }

        private void Menu_MouseMove(object sender, MouseEventArgs e)
        {
            timer6.Stop();
            lblMinute.Visible = false;
            lblSecond.Visible = false;
            label1.Visible = false;
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FaturaOdeme faturaOdeme = new FaturaOdeme();
            faturaOdeme.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Hakkinda hakkinda = new Hakkinda();
            hakkinda.ShowDialog();
        }
    }
}
