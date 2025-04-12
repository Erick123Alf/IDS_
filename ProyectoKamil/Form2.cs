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

        private void button3_Click(object sender, EventArgs e)
        {
            bool esDirectivo = radioButton1.Checked;
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {
                SqlCommand comm = new SqlCommand("UPDATE Empleado SET NumeroEmpleado = '" + textNumEmp.Text + "', Nombre = '" + textNombre.Text + "' ApellidoPaterno = '" + textAP.Text + "', ApellidoMaterno = '" + textAM.Text + "', FechaNacimiento = '" + textNac.Text + "', RFC = '" + textRFC.Text + "' , CentroTrabajo = '" + textCentTrab.Text + "', Puesto = '" + textPuesto.Text + "' , DescripPuesto = '" +textDesc.Text + "' , Directivo = '" + esDirectivo + "' ", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();
               
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

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True"))
            {
                SqlDataAdapter dat = new SqlDataAdapter("SELECT * FROM Empleado", cn);
            dat.SelectCommand.CommandType = CommandType.Text;
            cn.Open();
            dat.Fill(dt);
        }
        dataGView.DataSource = dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            /*if (radioButton1.Checked == true)
            {
                MessageBox.Show("Si es Directivo");
            }
            
            switch("Directivo")
            {
                case "Si":
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    break;
            }*/
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            /*if (radioButton2.Checked == true)
            {
                MessageBox.Show("No es Directivo");
            }

            switch("Directivo")
            {
                case "No":
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    break;
            }*/
        }

    }
}
