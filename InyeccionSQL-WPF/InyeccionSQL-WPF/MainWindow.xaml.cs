using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient; //INSERTADO

namespace InyeccionSQL_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection conexion = new SqlConnection("server= ASATA408\\SQLEXPRESSSAUL; database=PruebaInyeccionSQL; Persist Security Info=True;User ID=sa;PassWord=1234");
        public MainWindow()
        {
            InitializeComponent();
        }


        private void bntInsertar_Click(object sender, RoutedEventArgs e)
        {
            conexion.Open();
            string iden = txtID.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            Boolean valida=true;

            if (txtID.Text == "" || txtNombre.Text == "" || txtEdad.Text == "")
            { MessageBox.Show("Faltán datos"); }
            else
            {
                string cadenavalida = "select id,nombre,edad from Personas Where id=" + iden;
                SqlCommand comandovalida = new SqlCommand(cadenavalida, conexion);
                SqlDataReader registro = comandovalida.ExecuteReader();
                if (registro.Read()) { valida = true; }
                else { valida = false; }
                conexion.Close();


                if (valida == true)
                { MessageBox.Show("Valor no válido"); }
                else
                {
                    conexion.Open();
                    string cadena = "insert into Personas(id,nombre,edad)" + "values (" + iden + ",'" + nombre + "'," + edad + ")";
                    SqlCommand comando = new SqlCommand(cadena, conexion);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Los datos se guardaron correctamente");
                    txtID.Text = "";
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                }
            }
            conexion.Close();
        }

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {
            if (txtIdEliminar.Text == "")
            { MessageBox.Show("Valor no introducido"); }
            else
            {
                conexion.Open();
                string id = txtIdEliminar.Text;
                string cadena = "select id,nombre,edad from Personas Where id=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    LabelNombre.Content = registro["nombre"].ToString();
                    LabelEdad.Content = registro["edad"].ToString();
                    btnBorrar.IsEnabled = true;
                }
                else { MessageBox.Show("No existe un artículo con el código ingresado"); }
            }
            conexion.Close();


        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (txtIdEliminar.Text == "")
            { MessageBox.Show("Valor no introducido"); }
            else
            {

                conexion.Open();
                string iden = txtIdEliminar.Text;
                string cadena = "delete from Personas where id=" + iden;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    LabelNombre.Content = "";
                    LabelEdad.Content = "";
                    txtIdEliminar.Text = "";
                    MessageBox.Show("Se borró el artículo");
                }
                else { MessageBox.Show("No existe un artículo con el código ingresado"); }
            }
            conexion.Close();
            btnBorrar.IsEnabled = false;
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if (txtModificarID.Text == "")
            { MessageBox.Show("Valor no introducido"); }
            else
            {
                conexion.Open();
                string cod = txtModificarID.Text;
                string cadena = "select id, nombre, edad from Personas where id=" + cod;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    txtModificarNombre.Text = registro["nombre"].ToString();
                    txtModificarEdad.Text = registro["edad"].ToString();
                }
                else { MessageBox.Show("No existe un artículo con el código ingresado"); }
            }
            conexion.Close();
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (txtModificarID.Text == "" || txtModificarNombre.Text == "" || txtModificarEdad.Text == "")
            { MessageBox.Show("Falta algún valor"); }
            else
            {

                conexion.Open();
                string id = txtModificarID.Text;
                string nombre = txtModificarNombre.Text;
                string edad = txtModificarEdad.Text;
                string cadena = "update Personas set nombre='" + nombre + "', edad=" + edad + " where id=" + id;
                SqlCommand comando = new SqlCommand(cadena, conexion);
                int cant;
                cant = comando.ExecuteNonQuery();
                if (cant == 1)
                {
                    MessageBox.Show("Se modificaron los datos del artículo");
                    txtModificarID.Text = "";
                    txtModificarNombre.Text = "";
                    txtModificarEdad.Text = "";
                }
                else { MessageBox.Show("No existe un artículo con el código ingresado"); }
            }
            conexion.Close();
        }
    }
}
