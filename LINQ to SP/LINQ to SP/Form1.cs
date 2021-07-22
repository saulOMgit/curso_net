using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_to_SP
{
    public partial class Form1 : Form
    {
        //Creamos la clase de acceso a SQL SERVER
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtTelefono.Text = "";
            txtBuscar.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClienteLinq.insertarcliente(txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text);
            this.listarclientes();
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtTelefono.Text = "";
            txtBuscar.Text = "";

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "") MessageBox.Show("FALTA NOMBRE");
            else
            {
                ClienteLinq.Modificarcliente(txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text);
                this.listarclientes();
                txtNombre.Text = "";
                txtApellido1.Text = "";
                txtApellido2.Text = "";
                txtTelefono.Text = "";
                txtBuscar.Text = "";
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(txtNombre.Text);
            this.listarclientes();
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtTelefono.Text = "";
            txtBuscar.Text = "";

        }
        void listarclientes() 
        {
            GridDatos.DataSource = ClienteLinq.ListarClientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarclientes();
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            GridDatos.DataSource = ClienteLinq.buscarcliente(txtBuscar.Text);
            txtNombre.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
            txtTelefono.Text = "";
            txtBuscar.Text = "";
        }
    }
}
