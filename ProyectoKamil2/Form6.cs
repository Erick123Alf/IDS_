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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool prestaciones = radioButton1.Checked;
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {

                SqlCommand comm = new SqlCommand("UPDATE Empleado SET NumeroEmpleado = '" + textNumEmpleado.Text + "', Centro_Supervision = '" + textCentroSuper.Text + "' Prestacion_Combustible = '" + prestaciones + "' ", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido modificado con exito");

                textCentroSuper.Clear();
                textNumEmpleado.Clear();
                comm.Parameters.AddWithValue("@Prestacion_Combustible", prestaciones);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool prestaciones = radioButton1.Checked;
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {

                SqlCommand comm = new SqlCommand("DELETE FROM Empleado WHERE NumeroEmpleado = '" + textNumEmpleado.Text + "' ", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido eliminado con exito");

                textCentroSuper.Clear();
                textNumEmpleado.Clear();
                comm.Parameters.AddWithValue("@Prestacion_Combustible", prestaciones);
            }
        }
    }
}
