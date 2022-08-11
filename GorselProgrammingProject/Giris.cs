using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GorselProgrammingProject
{
    public partial class Giris : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        public Giris()
        {
            InitializeComponent();
        }
        public static string executiveId;
        public static string executivePassword;
        public static int bakiye;
        public static string ad;
        public static string soyad;
        public static string phone;
        public static string password;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            phone = textBoxPhone.Text;
            password = textBoxPassword.Text;
            txtBoxUsername.Text = executiveId;
            txtBoxPassword2.Text = executivePassword;
            Veritabani_Giris veritabani  = new Veritabani_Giris();
            veritabani.giris(phone,password,this);     
        }

        private void buttonOkey_MouseHover(object sender, EventArgs e)
        {
        
        }

        private void btnExecutive_Click(object sender, EventArgs e)
        {
            
            command = new SqlCommand("Select*From Executive where yonetici_id = '"+txtBoxUsername.Text+"' and yonetici_sifre = '"+txtBoxPassword2.Text+"'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Yönetici Girişi Başarılı");
                Yonetici yonetici = new Yonetici();
                yonetici.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                connection.Close();
                command.Dispose();
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
