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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        public bool kontrol;
        static string con = "Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True";
        SqlCommand command;
        SqlDataReader reader;
        SqlConnection connect = new SqlConnection(con);
        public void Kontrol()
        {
            command = new SqlCommand("Select*From Login where telefon =@telefon", connect);
            command.Parameters.AddWithValue("@telefon", textBoxPhone.Text);
            connect.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                kontrol = false;
            }
            else
            {
                kontrol = true;
            }
            connect.Close();
            command.Dispose();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (connect.State == ConnectionState.Closed)
            {
                Kontrol();
                if (kontrol == true)
                {
                
                    connect.Open();
                    string kayit = "insert into Login (musteri_ad, musteri_soyad, telefon, sifre, bakiye) values(@musteri_ad,@musteri_soyad,@telefon,@sifre,@bakiye)";
                    SqlCommand command = new SqlCommand(kayit, connect);
                    command.Parameters.AddWithValue("@musteri_ad", textBoxName.Text);
                    command.Parameters.AddWithValue("@musteri_soyad", textBoxSurname.Text);
                    command.Parameters.AddWithValue("@telefon", textBoxPhone.Text);
                    command.Parameters.AddWithValue("@sifre", textBoxPassword.Text);
                    command.Parameters.AddWithValue("@bakiye", textBoxBudget.Text);
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Kayıtlar Başarıyla Eklendi");
                    var dialogResult = MessageBox.Show("Ana Menüye Dönmek İstiyor musunuz?", "Ana Menü", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Anasayfa anasayfa = new Anasayfa();
                        anasayfa.ShowDialog();
                    }
                    if (dialogResult == DialogResult.No)
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir kayıt zaten var!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar !=8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
