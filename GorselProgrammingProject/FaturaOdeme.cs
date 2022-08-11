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
    public partial class FaturaOdeme : Form
    {
        public FaturaOdeme()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        
        public static int newTotal;
        public static int totalBalance;
        private void btnInternet_Click(object sender, EventArgs e)
        {
            btnElectric.Visible = false;
            btnWater.Visible = false;
            btnGas.Visible = false;
            lblInformation.Text = ("İnternet Faturanız = 150 TL");
            lblInformation.Visible = true;
            var dialogResult = MessageBox.Show("İnternet Faturanızı Ödemek İstiyor musunuz?", "Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                newTotal = totalBalance - 150;
               
                if (newTotal > 0)
                {
                    command = new SqlCommand("Update Login set bakiye = '" + (newTotal) + "' where id = '" + ParaCekme.id + "'", connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Fatura Ödeme İşleminiz Tamamlandı!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    command.Dispose();
                    lblNewTotal.Text = ("Hesabınızda kalan toplam tutar = " + newTotal + " TL");
                    lblNewTotal.Visible = true;
                    totalBalance = totalBalance - 150;
                    Giris.bakiye = totalBalance;
                }
                else
                {
                    MessageBox.Show("Ödeme İçin Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                FaturaOdeme faturaOdeme = new FaturaOdeme();
                faturaOdeme.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnInternet.Visible = false;
            btnGas.Visible = false;
            btnWater.Visible = false;
            Random random = new Random();
            int electric = random.Next(150, 300);
            lblInformation.Text = ("Elektrik faturanız = " + electric +" TL");
            lblInformation.Visible = true;
            var dialogResult = MessageBox.Show("Elektrik Faturanızı Ödemek İstiyor musunuz?", "Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                newTotal = totalBalance - electric;
                if (newTotal > 0)
                {
                    command = new SqlCommand("Update Login set bakiye = '" + (newTotal) + "' where id = '" + ParaCekme.id + "'", connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Fatura Ödeme İşleminiz Tamamlandı!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    command.Dispose();
                    lblNewTotal.Text = ("Hesabınızda kalan toplam tutar = " + newTotal + " TL");
                    lblNewTotal.Visible = true;
                    totalBalance = totalBalance - electric;
                    Giris.bakiye = totalBalance;
                }
                else
                {
                    MessageBox.Show("Ödeme İçin Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                FaturaOdeme faturaOdeme = new FaturaOdeme();
                faturaOdeme.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnInternet.Visible = false;
            btnElectric.Visible = false;
            btnGas.Visible = false;
            Random random = new Random();
            int water = random.Next(50, 150);
            lblInformation.Text = ("Su faturanız = " + water + " TL");
            lblInformation.Visible = true;
            var dialogResult = MessageBox.Show("Su Faturanızı Ödemek İstiyor musunuz?", "Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                newTotal = totalBalance - water;
                if (newTotal > 0)
                {
                    command = new SqlCommand("Update Login set bakiye = '" + (newTotal) + "' where id = '" + ParaCekme.id + "'", connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Fatura Ödeme İşleminiz Tamamlandı!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    command.Dispose();
                    lblNewTotal.Text = ("Hesabınızda kalan toplam tutar = " + newTotal + " TL");
                    lblNewTotal.Visible = true;
                    totalBalance = totalBalance - water;
                    Giris.bakiye = totalBalance;
                }
                else
                {
                    MessageBox.Show("Ödeme İçin Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                FaturaOdeme faturaOdeme = new FaturaOdeme();
                faturaOdeme.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnInternet.Visible = false;
            btnElectric.Visible = false;
            btnWater.Visible = false;
            Random random = new Random();
            int gas = random.Next(400, 1000);
            lblInformation.Text = ("Doğalgaz faturanız = " + gas + " TL");
            lblInformation.Visible = true;
            var dialogResult = MessageBox.Show("Doğalgaz Faturanızı Ödemek İstiyor musunuz?", "Ödeme", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                newTotal = totalBalance - gas;
                if (newTotal > 0 )
                {
                    command = new SqlCommand("Update Login set bakiye = '" + (newTotal) + "' where id = '" + ParaCekme.id + "'", connection);
                    connection.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show("Fatura Ödeme İşleminiz Tamamlandı!", "Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    command.Dispose();
                    lblNewTotal.Text = ("Hesabınızda kalan toplam tutar = " + newTotal + " TL");
                    lblNewTotal.Visible = true;
                    totalBalance = totalBalance - gas;
                    Giris.bakiye = totalBalance;
                }
                else
                {
                    MessageBox.Show("Ödeme İçin Yeterli Bakiyeniz Bulunmamaktadır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                FaturaOdeme faturaOdeme = new FaturaOdeme();
                faturaOdeme.ShowDialog();
            }
        }

        private void FaturaOdeme_Load(object sender, EventArgs e)
        {
            totalBalance = Giris.bakiye;
        }
    }
    }

