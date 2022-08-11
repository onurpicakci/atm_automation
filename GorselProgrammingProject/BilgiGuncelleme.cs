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
    public partial class BilgiGuncelleme : Form
    {
        public BilgiGuncelleme()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        private void BilgiGuncelleme_Load(object sender, EventArgs e)
        {
            lblName.Text = Giris.ad+Giris.soyad;
            lblSurname.Text = Giris.soyad;
      
            
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkey_Click(object sender, EventArgs e)
        {
            if (txtBoxNewPassword.Text == txtBoxNewPasswordAgain.Text)
            {
                if (txtBoxNewPassword.Text == Giris.password || txtBoxNewPasswordAgain.Text == Giris.password) 
                {
                    MessageBox.Show("Yeni Şifreniz Mevcut Şifrenizle Aynı Olamaz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    command = new SqlCommand("Update Login set sifre =  '" + txtBoxNewPassword.Text + "' where id = '" + ParaCekme.id + "'", connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Şifreniz Başarıyla Değiştirildi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    command.Dispose();
                }
                
            }
            else
            {
                MessageBox.Show("Girdiğiniz Şifreler Uyuşmuyor", "Hata", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            
        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void buttonOkey_Click(object sender, EventArgs e)
        {
            if (txtBoxNewPhone.Text == txtBoxNewPhoneAgain.Text)
            {
                if (txtBoxNewPhone.Text == Giris.phone || txtBoxNewPhoneAgain.Text == Giris.phone)
                {
                    MessageBox.Show("Yeni Telefon Numaranız Mevcut Telefon Numaranızla Aynı Olamaz", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    command = new SqlCommand("Update Login set telefon =  '" + txtBoxNewPhone.Text + "' where id = '" + ParaCekme.id + "'", connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Telefon Numaranız Başarıyla Değiştirildi", "Onay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    command.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Girdiğiniz Telefon Numaraları Uyuşmuyor", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            }

        private void lblNewPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblNewPhoneAgain_Click(object sender, EventArgs e)
        {

        }

        private void lblSurname_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

