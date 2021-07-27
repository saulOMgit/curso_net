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

namespace AlumnosSQL
{
    public partial class Form1 : Form
    {
        //Creamos la clase de acceso a SQL SERVER
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        
        private SqlConnection conexion = new SqlConnection("server= ASATA408\\SQLEXPRESSSAUL; database=AlumnosSQL; Persist Security Info=True;User ID=sa;PassWord=1234");
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string dni=txtDNI.Text;
            string nombre = txtNombre.Text;
            string turno = cbTurno.Text;
            string sexo = cbSexo.Text;
            string especialidad = cbEspecialidad.Text;
            string modulo = cbModulo.Text;
            int repite;
            if (txtDNI.Text == "" || txtNombre.Text == "" || cbEspecialidad.Text == "" || cbModulo.Text == "" || cbSexo.Text == "" || cbTurno.Text == "")
            { MessageBox.Show("Faltan Datos"); }
            else
            {
                if (chkModulo.Checked == true) { repite = 1; }
                else { repite = 0; }
                string cadena = "insert into Alumnos(Nombre,DNI,Turno,Sexo,Repetidor,Modulo,Especialidad)" + "values('" + nombre + "','" + dni + "','" + turno + "','" + sexo + "'," + repite + ",'" + modulo + "','" + especialidad + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Los datos se guardaron correctamente");
                this.listarclientes();
                txtNombre.Text = "";
                txtDNI.Text = "";
                txtCodigo.Text = "";
            }
            conexion.Close();
        }
        void listarclientes()
        {
            GridDatos.DataSource = ClienteLinq.spListarAlumnos();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarclientes();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string dni = txtDNI.Text;
            string cadena = "delete from Alumnos where dni='" + dni + "'";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1) 
            {
                txtDNI.Text = "";
                txtNombre.Text = "";
                cbTurno.Text = "Diurno";
                cbModulo.Text = "DAW";
                cbSexo.Text = "Poquito";
                MessageBox.Show("Se elimino el Alumno de DNI " + dni);
            }
            else { MessageBox.Show("No existe un alumno con ese DNI"); }
            conexion.Close();
            this.listarclientes();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string turno = cbTurno.Text;
            string sexo = cbSexo.Text;
            string especialidad = cbEspecialidad.Text;
            string modulo = cbModulo.Text;
            int repite;
            if (chkModulo.Checked == true) { repite = 1; }
            else { repite = 0; }
            if (txtDNI.Text == "")
            { MessageBox.Show("No existe un alumno con el DNI: " + dni); }
            else
            {
                string cadena = "update Alumnos set nombre='" + nombre + "',turno='" + turno + "',sexo='" + sexo + "',especialidad='" + especialidad + "',modulo='" + modulo + "',repetidor='" + repite + "' WHERE DNI='"+dni+"'";
                SqlCommand command = new SqlCommand(cadena, conexion);
                command.ExecuteNonQuery();
                MessageBox.Show("Modificacion realizada");
            }
            conexion.Close();
            this.listarclientes();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
