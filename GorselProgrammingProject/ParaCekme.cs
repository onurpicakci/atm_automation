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
    public partial class ParaCekme : Form
    {
        public ParaCekme()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void ParaCekme_Load(object sender, EventArgs e)
        {
            guncelBakiye = Giris.bakiye;
            lblTotal.Text = ("Toplam Bakiye = " + Giris.bakiye.ToString());
        }
        
        public static int id;
        public static int guncelBakiye;
        
        public static int totalBalance;
        private void btn10_Click(object sender, EventArgs e)
        {
            totalBalance = guncelBakiye - 10;
            if (totalBalance >= 0)
            {
                guncelBakiye = guncelBakiye - 10;
                Giris.bakiye = guncelBakiye;
                command = new SqlCommand("Update Login set bakiye = '" + (totalBalance) + "' where id = '" + id + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Para Çekme İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
                lblTotal.Visible = false;
                lblNewTotal.Text = ("Yeni Bakiye = " + (totalBalance).ToString());

                connection.Close();
                command.Dispose();
                
                
            }
            else
            {
                MessageBox.Show("Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void btn100_Click(object sender, EventArgs e)
        {
            totalBalance = guncelBakiye- 100;
            if (totalBalance >= 0)
            {
                guncelBakiye = guncelBakiye - 100;
                Giris.bakiye = guncelBakiye;
                command = new SqlCommand("Update Login set bakiye = '" + (totalBalance) + "' where id = '" + id + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Para Çekme İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
                lblTotal.Visible = false;
                lblNewTotal.Text = ("Yeni Bakiye = " + (totalBalance).ToString());

                connection.Close();
                command.Dispose();
                
            }
            else
            {
                MessageBox.Show("Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            totalBalance = guncelBakiye - 20;
            if (totalBalance >= 0)
            {
                guncelBakiye = guncelBakiye - 20;
                Giris.bakiye = guncelBakiye;
                command = new SqlCommand("Update Login set bakiye = '" + (totalBalance) + "' where id = '" + id + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Para Çekme İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
                lblTotal.Visible = false;
                lblNewTotal.Text = ("Yeni Bakiye = " + (totalBalance).ToString());

                connection.Close();
                command.Dispose();
                
            }
            else
            {
                MessageBox.Show("Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            totalBalance = guncelBakiye - 50;
            if (totalBalance >= 0)
            {
                guncelBakiye = guncelBakiye - 50;
                Giris.bakiye = guncelBakiye;
                command = new SqlCommand("Update Login set bakiye = '" + (totalBalance) + "' where id = '" + id + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Para Çekme İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
                lblTotal.Visible = false;
                lblNewTotal.Text = ("Yeni Bakiye = " + (totalBalance).ToString());

                connection.Close();
                command.Dispose();
            }
            else
            {
                MessageBox.Show("Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            totalBalance = guncelBakiye - 200;
            if (totalBalance >= 0)
            {
                guncelBakiye = guncelBakiye - 200;
                Giris.bakiye = guncelBakiye;
                command = new SqlCommand("Update Login set bakiye = '" + (totalBalance) + "' where id = '" + id + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Para Çekme İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
                lblTotal.Visible = false;
                lblNewTotal.Text = ("Yeni Bakiye = " + (totalBalance).ToString());

                connection.Close();
                command.Dispose();
            }
            else
            {
                MessageBox.Show("Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            totalBalance = guncelBakiye - 500;
            if (totalBalance >= 0)
            {
                guncelBakiye = guncelBakiye - 500;
                Giris.bakiye = guncelBakiye;
                command = new SqlCommand("Update Login set bakiye = '" + (totalBalance) + "' where id = '" + id + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Para Çekme İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
                lblTotal.Visible = false;
                lblNewTotal.Text = ("Yeni Bakiye = " + (totalBalance).ToString());

                connection.Close();
                command.Dispose();
            }
            else
            {
                MessageBox.Show("Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBoxDiger_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int different;
            different = Convert.ToInt32(txtBoxDifferent.Text);
            
            if (different % 10 == 0)
            {
                totalBalance = guncelBakiye - Convert.ToInt32(txtBoxDifferent.Text);
                if (totalBalance >= 0)
                {
                    guncelBakiye = guncelBakiye - Convert.ToInt32(txtBoxDifferent.Text);
                    Giris.bakiye = guncelBakiye;
                    command = new SqlCommand("Update Login set bakiye = '" + totalBalance + "' where id = '" + id + "'", connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Para Çekme İşleminiz Tamamlandı", "Onay", MessageBoxButtons.OK);
                    lblTotal.Visible = false;
                    lblNewTotal.Text = ("Yeni Bakiye = " + totalBalance);
                    connection.Close();
                    command.Dispose();
                }
                else
                {
                    MessageBox.Show("Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz Tutar 10 TL ve Katları Olmak Zorundadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            
        }
    }
}
