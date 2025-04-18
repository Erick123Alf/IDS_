using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoKamil2
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True"))
            {
                SqlDataAdapter dat = new SqlDataAdapter("SELECT * FROM Catalogo", cn);
                dat.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                dat.Fill(dt);
            }
            dataGView.DataSource = dt;
        }
    }
}
