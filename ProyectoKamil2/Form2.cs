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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool esDirectivo = radioButton1.Checked;
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand comm = new SqlCommand("INSERT INTO Empleado (NumeroEmpleado, Nombre, ApellidoPaterno, ApellidoMaterno, FechaNacimiento, RFC, CentroTrabajo, Puesto, DescripPuesto, Directivo) VALUES ('" + textNumEmp.Text + "' , '" + textNombre.Text + "', '" + textAP.Text + "', '" + textAM.Text + "', '" + textNac.Text + "', '" + textRFC.Text + "', '" + textCentTrab.Text + "', '" + textPuesto.Text + "' , '" + textDesc.Text + "' , '" + esDirectivo + "' )", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido registrado con exito");

                

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
