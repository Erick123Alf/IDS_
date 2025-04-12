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
using static System.Net.Mime.MediaTypeNames;

namespace ProyectoKamil
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True"))
            {
                SqlDataAdapter dat = new SqlDataAdapter("SELECT * FROM Directivo", cn);
                dat.SelectCommand.CommandType = CommandType.Text;
                cn.Open();
                dat.Fill(dt);
            }
            dataGView.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool prestaciones = radioButton1.Checked;
            using (SqlConnection con = new SqlConnection("Data Source=Erick\\SQLEXPRESS;Initial Catalog=Kamil;Integrated Security=True;Encrypt=False"))
            {
                
                SqlCommand comm = new SqlCommand("INSERT INTO Directivo(NumeroEmpleado, Centro_Supervision, Prestacion_Combustible) VALUES ( '" + textNumEmpleado.Text +"' , '"+textCentroSuper.Text +"' , '" + prestaciones + "' )", con);
                comm.CommandType = CommandType.Text;
                con.Open();
                comm.ExecuteNonQuery();

                MessageBox.Show("Empleado ha sido registrado con exito");

                textCentroSuper.Clear();
                textNumEmpleado.Clear();
                comm.Parameters.AddWithValue("Prestacion_Combustible", prestaciones);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
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
    }
}
