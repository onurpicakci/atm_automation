using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GorselProgrammingProject
{
    class Veritabani_Giris
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        public void giris(string number, string password, Form form1)
        {
            command = new SqlCommand("Select * From Login where telefon = '" + number + "' and sifre = '" + password + "'", connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                Giris.ad = reader["musteri_ad"].ToString();
                Giris.bakiye = Convert.ToInt32( reader["bakiye"].ToString());
                Giris.soyad = reader["musteri_soyad"].ToString();
                ParaCekme.id = Convert.ToInt32(reader["id"].ToString());
                Menu menu = new Menu();
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                connection.Close();
                command.Dispose();
            }
            

        }
    }
}
