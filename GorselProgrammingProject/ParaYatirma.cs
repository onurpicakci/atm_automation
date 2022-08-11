using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GorselProgrammingProject
{
    public partial class ParaYatirma : Form
    {
        public ParaYatirma()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        public static int para;
        private void btnYatir10_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Update Login set bakiye = '" + (para + 10) + "' where id = '" + ParaCekme.id + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            MessageBox.Show("Para Yatırma İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
            lblTotal.Visible = false;
            lblNewTotal.Text = ("Yeni Bakiye = " + (para + 10).ToString());
            para = para + 10;
            Giris.bakiye = para;
            connection.Close();
            command.Dispose();
        }
        
        private void ParaYatirma_Load(object sender, EventArgs e)
        {
            para = Giris.bakiye;
            lblTotal.Text = ("Toplam Hesap Bakiyeniz = " + Giris.bakiye.ToString());
            
        }

        private void btnYatir20_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Update Login set bakiye = '" + (para + 20) + "' where id = '" + ParaCekme.id + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            MessageBox.Show("Para Yatırma İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
            lblTotal.Visible = false;
            lblNewTotal.Text = ("Yeni Bakiye = " + (para + 20).ToString());
            para = para + 20;
            Giris.bakiye = para;
            connection.Close();
            command.Dispose();
        }

        private void btnYatir50_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Update Login set bakiye = '" + (para + 50) + "' where id = '" + ParaCekme.id + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            MessageBox.Show("Para Yatırma İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
            lblTotal.Visible = false;
            lblNewTotal.Text = ("Yeni Bakiye = " + (para + 50).ToString());
            para = para + 50;
            Giris.bakiye = para;
            connection.Close();
            command.Dispose();
        }

        private void btnYatir100_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Update Login set bakiye = '" + (para + 100) + "' where id = '" + ParaCekme.id + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            MessageBox.Show("Para Yatırma İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
            lblTotal.Visible = false;
            lblNewTotal.Text = ("Yeni Bakiye = " + (para + 100).ToString());
            para = para + 100;
            Giris.bakiye = para;
            connection.Close();
            command.Dispose();
        }

        private void btnYatir200_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Update Login set bakiye = '" + (para + 200) + "' where id = '" + ParaCekme.id + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            MessageBox.Show("Para Yatırma İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
            lblTotal.Visible = false;
            lblNewTotal.Text = ("Yeni Bakiye = " + (para + 200).ToString());
            para = para + 200;
            Giris.bakiye = para;
            connection.Close();
            command.Dispose();
        }

        private void btnYatir500_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("Update Login set bakiye = '" + (para + 500) + "' where id = '" + ParaCekme.id + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            MessageBox.Show("Para Yatırma İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
            lblTotal.Visible = false;
            lblNewTotal.Text = ("Yeni Bakiye = " + (para + 500).ToString());
            para = para + 500;
            Giris.bakiye = para;
            connection.Close();
            command.Dispose();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            int different;
            different = Convert.ToInt32(txtBoxDifferent.Text);
            
            if (different % 10 == 0)
            {
                para = para + Convert.ToInt32(txtBoxDifferent.Text);
                Giris.bakiye = para;
                command = new SqlCommand("Update Login set bakiye = '" + para + "' where id = '" + ParaCekme.id + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Para Yatırma İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
                lblTotal.Visible = false;
                lblNewTotal.Text = ("Yeni Bakiye = " + para);

                connection.Close();
                command.Dispose();
            }
            else
            {
                MessageBox.Show("Girdiğiniz Tutar 10 TL ve Katları Olmak Zorundadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 

        }
    }
}
