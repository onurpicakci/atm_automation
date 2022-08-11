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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Kayit form1 = new Kayit();
            form1.ShowDialog();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Giris form2 = new Giris();
            form2.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            lblBankName.Text = ("OSSOBANK'a Hoşgeldiniz");
        }
    }
}

