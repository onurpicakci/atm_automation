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
    public partial class Havale : Form
    {
        public Havale()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        private void Havale_Load(object sender, EventArgs e)
        {
            transferMoney = Giris.bakiye;
            lblName1.Text = Giris.ad;
            lblSurname1.Text = Giris.soyad;
            lblTotal.Text = transferMoney.ToString();
            
        }
        public string phone;
        public int newId;
        public string transferCustomerName;
        public string transferCustomerSurname;
        public int newBudget;
        public int transferMoney;
        private void btnOkey_Click(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == Giris.phone)
            {
                MessageBox.Show("Kendi Telefon Numaranızı Giremezsiniz!", "Hata", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                phone = textBoxPhone.Text;
                command = new SqlCommand("Select*From Login where telefon ='" + phone + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Giriş Başarılı");
                    transferCustomerName = reader["musteri_ad"].ToString();
                    transferCustomerSurname = reader["musteri_soyad"].ToString();
                    newId = Convert.ToInt32(reader["id"].ToString());
                    newBudget = Convert.ToInt32(reader["bakiye"].ToString());
                    lblName.Text = transferCustomerName;
                    lblName.Visible = true;
                    lblSurname.Text = transferCustomerSurname;
                    lblSurname.Visible = true;
                    MessageBox.Show("Havale Yapacağınız Kişinin Bilgilerini Kontrol Ediniz", "Havale", MessageBoxButtons.OK);
                    checkBoxOkey.Visible = true;
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş");

                }
                connection.Close();
                command.Dispose();
            }
            
        }

       private void checkBoxOkey_CheckedChanged_1(object sender, EventArgs e)
        {
            lblPhone.Visible = false;
            textBoxPhone.Visible = false;
            btnLogin.Visible = false;
            checkBoxOkey.Visible = false;
            lblTransferAccount.Visible = true;
            textBoxTransfer.Visible = true;
            btnOkey.Visible = true;

        }

        private void btnOkey_Click_1(object sender, EventArgs e)
        {
            int transfer =  (transferMoney - Convert.ToInt32(textBoxTransfer.Text));
            if (transfer >= 0)
            {
                transferMoney = transferMoney - Convert.ToInt32(textBoxTransfer.Text);
                Giris.bakiye = transferMoney;
                command = new SqlCommand("Update Login set bakiye = '" + transfer + "' where id = '" + ParaCekme.id + "'", connection);
                connection.Open();
                reader = command.ExecuteReader();
                connection.Close();
                command.Dispose();

                int newTransfer = (newBudget + Convert.ToInt32(textBoxTransfer.Text));
                SqlCommand command2 = new SqlCommand("Update Login set bakiye = '" + newTransfer + "' where id = '" + newId + "'", connection);
                connection.Open();
                reader = command2.ExecuteReader();
                MessageBox.Show("Havale işleminizi başarıyla tamamlandı");
                lblTotal.Text = transferMoney.ToString();

                connection.Close();
                command2.Dispose();

            }
            else
            {
                MessageBox.Show("Havale Yapacağınız Tutar Kadar Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            

        }

        private void textBoxTransfer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxTransfer_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
