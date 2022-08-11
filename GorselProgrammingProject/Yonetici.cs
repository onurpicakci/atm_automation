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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
      
        static string constring = "Data Source=DESKTOP-KJ4U0D8;Initial Catalog=Project;Integrated Security=True";
        SqlConnection connect = new SqlConnection(constring);

        private void Yonetici_Load(object sender, EventArgs e)
        {
            connect.Open();
            string select = "Select*from Login";
            SqlDataAdapter adapter = new SqlDataAdapter(select, connect);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connect.Close();
        }
    }
}
