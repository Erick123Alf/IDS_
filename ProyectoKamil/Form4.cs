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

namespace ProyectoKamil
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {

                SqlCommand comm = new SqlCommand("DELETE FROM Empleado WHERE NumeroEmpleado = '" + textNumCentro.Text + "' ", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido eliminado con exito");

                textNumCentro.Clear();
                textNombreCentro.Clear();
                textCiudad.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {

                SqlCommand comm = new SqlCommand("UPDATE Empleado SET NumeroCentro = '" + textNumCentro.Text + "', NombreCentro = '" + textNombreCentro.Text + "' Ciudad = '" + textCiudad.Text + "' ", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido modificado con exito");

                textCiudad.Clear();
                textNombreCentro.Clear();
                textNumCentro.Clear();

            }
        }
    }
}