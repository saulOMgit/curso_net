using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenParcial25_08Saúl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DEFINIMOS LA CLASE
        DataClasses1DataContext dbExamen = new DataClasses1DataContext();
     

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
            CargarCombo();
        }

        //METODO PARA ALIMENTAR EL GRID
        void CargarGrid() 
        {
            var cargarGrid = from u in dbExamen.PRODUCTOS select u;
            GridDatos.DataSource = cargarGrid;
            CargarCombo();
        }

        void CargarCombo() 
        {
            var cargaCombo = from u in dbExamen.PRODUCTOS select u.NombreProducto;
            cbProductos.DataSource = cargaCombo;
        }

        //BOTÓN PARA AÑADIR PRODUCTOS
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                //DEFINIMOS PRODUCTO
                PRODUCTOS MyProducto = new PRODUCTOS();

                //INSERTAMOS LOS CAMPOS
                MyProducto.NombreProducto = txtNuevoProducto.Text;
                MyProducto.PrecioUnidad = decimal.Parse(txtPrecioUni.Text);
                MyProducto.UnidadStock = int.Parse(txtUnidadesStock.Text);

                //AÑADIMOS EL REGISTRO A LA BASE DE DATOS
                dbExamen.PRODUCTOS.InsertOnSubmit(MyProducto);
                //CONFIRMAMOS
                dbExamen.SubmitChanges();
                //CARGAMOS GRID PARA VER LOS RESULTADOS
                CargarGrid();

                //LIMPIAMOS LOS CAMPOS
                txtNuevoProducto.Text = "";
                txtPrecioUni.Text = "";
                txtUnidadesStock.Text = "";
            }
            catch 
            {
                if (txtNuevoProducto.Text == "" || txtPrecioUni.Text == "" || txtUnidadesStock.Text == "") 
                {
                    MessageBox.Show("Falta algún dato");
                }
                else { MessageBox.Show("Valor incorrecto"); }
            }
        }
        //BOTÓN PARA ELIMINAR PRODUCTOS
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //ELIMINAREMOS SEGUN EL NOMBRE DEL PRODUCTO QUE ESCOGEMOS
                //EN EL COMBOBOX

                PRODUCTOS MyProductos = dbExamen.PRODUCTOS.Single(u =>
                  u.NombreProducto == cbProductos.Text);

                //Eliminamos
                dbExamen.PRODUCTOS.DeleteOnSubmit(MyProductos);
                dbExamen.SubmitChanges();
                CargarGrid();
            }
            catch 
            {
                if (cbProductos.Text == "") { MessageBox.Show("Seleccione un producto"); }
                else { MessageBox.Show("Valor incorrecto"); }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Expresion lamba para buscar un producto que coincida con el cb
                //y modificarlo
                PRODUCTOS MyProducto = dbExamen.PRODUCTOS.Single(u =>
                u.NombreProducto == cbProductos.Text);
                MyProducto.PrecioUnidad = decimal.Parse(txtPrecioUni.Text);
                MyProducto.UnidadStock = int.Parse(txtUnidadesStock.Text);

                //GUARDAMOS LOS CAMBIOS
                dbExamen.SubmitChanges();

                CargarGrid();
            }
            catch 
            {
                if (cbProductos.Text == "") { MessageBox.Show("Seleccione un producto"); }
                else if (txtPrecioUni.Text == "" && txtUnidadesStock.Text == "") { MessageBox.Show("No has realizado modificaciones");}
                else { MessageBox.Show("Valor incorrecto"); };                
            }
        }

        //BOTON PARA BUSCAR 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text != "") 
                {
                    PRODUCTOS MyProducto = dbExamen.PRODUCTOS.Single(u =>
                      u.NombreProducto.Contains(txtBuscar.Text));

                    //CARGAMOS LOS TEXBOX
                    txtNuevoProducto.Text = MyProducto.NombreProducto;
                    txtPrecioUni.Text = MyProducto.PrecioUnidad.ToString();
                    txtUnidadesStock.Text = MyProducto.UnidadStock.ToString();

                    var buscarNombre = from PRODUCTOS in dbExamen.PRODUCTOS where PRODUCTOS.NombreProducto.Contains(txtNuevoProducto.Text) select PRODUCTOS;

                    GridDatos.DataSource = buscarNombre; 
                }
                else { CargarGrid(); }
            }
            catch 
            {
                MessageBox.Show("No se encuentra ningún producto coincidente");
            }

        }
    }
}
