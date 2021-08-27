using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRUEBA_PRÁCTICA_UNIDAD_UF1846
{
    public partial class Form1 : Form
    {
        //Creamos la clase de acceso a SQL SERVER
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
            this.listarclientes();
            this.listarcombo();
        }
        //Alimentamos el GRID
        void listarclientes() 
        {
            GridDatos.DataSource = ClienteLinq.ListarTodos();
        }
        //Alimentamos el Combo
        void listarcombo() 
        {
            cbProductos.DataSource = ClienteLinq.listarCombo();
            cbProductos.DisplayMember = "NombreProducto";
        }

        //Botón para añadir productos
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoProducto.Text == "")
                {
                    MessageBox.Show("Introduzca Producto a Añadir");
                }
                else
                {
                    ClienteLinq.sp_AñadirProducto(txtNuevoProducto.Text, decimal.Parse(txtPrecioUni.Text), int.Parse(txtUnidadesStock.Text));
                    this.listarclientes();
                    this.listarcombo();
                }
            }
            catch 
            {
                if (txtNuevoProducto.Text == "") 
                {
                    MessageBox.Show("Introduzca Producto a Añadir");
                }
                else { MessageBox.Show("Producto repetido"); }
            }

        }
        //Botón para modificar productos
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProductos.Text == "") { MessageBox.Show("Introduce Producto a modificar"); }
                else
                {
                    ClienteLinq.sp_ModificaProducto(cbProductos.Text, decimal.Parse(txtPrecioUni.Text), int.Parse(txtUnidadesStock.Text));
                    this.listarclientes();
                    this.listarcombo();
                }
            }
            catch 
            {
                MessageBox.Show("Producto no valido");
            }


        }
        //Botón para Eliminar productos
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbProductos.Text == "") { MessageBox.Show("Introduce Producto a eliminar"); }
                else
                {
                    ClienteLinq.sp_EliminarProducto(cbProductos.Text);
                    this.listarclientes();
                    this.listarcombo();
                }
            }
            catch
            {
                MessageBox.Show("Producto no valido");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarclientes();
            this.listarcombo();
        }

        //Boton para Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscar.Text == "") { MessageBox.Show("Introduce Producto a buscar"); }
                else
                {
                    GridDatos.DataSource = ClienteLinq.sp_BuscarCliente(txtBuscar.Text);
                }
            }
            catch
            {
                MessageBox.Show("Producto no valido");
            }
        }
        //Funcion para alimentar los TextBox clickando en el Grid
        private void GridDatos_SelectionChanged(object sender, EventArgs e)
        {
            int siguiente = GridDatos.CurrentRow.Index;


            txtNuevoProducto.Text = GridDatos.Rows[siguiente].Cells[0].Value.ToString();
            cbProductos.Text = GridDatos.Rows[siguiente].Cells[0].Value.ToString();
            txtPrecioUni.Text = GridDatos.Rows[siguiente].Cells[1].Value.ToString();
            txtUnidadesStock.Text = GridDatos.Rows[siguiente].Cells[2].Value.ToString();
        }
    }
}
