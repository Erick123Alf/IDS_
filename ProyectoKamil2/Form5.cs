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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool prestaciones = radioButton1.Checked;
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {

                SqlCommand comm = new SqlCommand("INSERT INTO Directivo(NumeroEmpleado, Centro_Supervision, Prestacion_Combustible) VALUES ( '" + textNumEmpleado.Text + "' , '" + textCentroSuper.Text + "' , '" + prestaciones + "' )", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido registrado con exito");

                textCentroSuper.Clear();
                textNumEmpleado.Clear();
                comm.Parameters.AddWithValue("Prestacion_Combustible", prestaciones);
            }
        }
    }
}
