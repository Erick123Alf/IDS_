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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {

                SqlCommand comm = new SqlCommand("INSERT INTO Catalogo (NumeroCentro, NombreCentro, Ciudad) VALUES ( '" + textNumCentro.Text + "' , '" + textNombreCentro.Text + "' , '" + textCiudad.Text + "' )", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido registrado con exito");

                textNumCentro.Clear();
                textNombreCentro.Clear();
                textCiudad.Clear();
            }
        }
    }
}
