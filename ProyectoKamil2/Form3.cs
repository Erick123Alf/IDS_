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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre, Ap_Pat, Ap_Mat, Nacimiento;
            bool esDirectivo = radioButton1.Checked;
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand comm = new SqlCommand("UPDATE Empleado SET NumeroEmpleado = '" + textNumEmp.Text + "', Nombre = '" + textNombre.Text + "' ApellidoPaterno = '" + textAP.Text + "', ApellidoMaterno = '" + textAM.Text + "', FechaNacimiento = '" + textNac.Text + "', RFC = '" + textRFC.Text + "' , CentroTrabajo = '" + textCentTrab.Text + "', Puesto = '" + textPuesto.Text + "' , DescripPuesto = '" + textDesc.Text + "' , Directivo = '" + esDirectivo + "' ", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                Nombre = textNombre.Text;
                Ap_Pat = textAP.Text;
                Ap_Mat = textAM.Text;
                Nacimiento = textNac.Text;


                MessageBox.Show("Empleado ha sido modificado con exito");

                textNumEmp.Clear();
                textNombre.Clear();
                textAP.Clear();
                textAM.Clear();
                textNac.Clear();
                textRFC.Clear();
                textCentTrab.Clear();
                textPuesto.Clear();
                textDesc.Clear();
                comm.Parameters.AddWithValue("@Directivo", esDirectivo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool esDirectivo = radioButton1.Checked;
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {

                SqlCommand comm = new SqlCommand("DELETE FROM Empleado WHERE NumeroEmpleado = '" + textNumEmp.Text + "' ", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido eliminado con exito");

                textNumEmp.Clear();
                textNombre.Clear();
                textAP.Clear();
                textAM.Clear();
                textNac.Clear();
                textRFC.Clear();
                textCentTrab.Clear();
                textPuesto.Clear();
                textDesc.Clear();
                comm.Parameters.AddWithValue("@Directivo", esDirectivo);

            }
        }
    }
}
