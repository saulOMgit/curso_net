using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioRepasoLunesLINQ
{
    public partial class Form1 : Form
    {
        //Creamos la clase de acceso a SQL SERVER
        DataClasses1DataContext ClienteLinq = new DataClasses1DataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //TRY CATCH COMPRUEBA SI HAY IDS REPETIDAS Y EVITA QUE CRASHEE EL PROGRAMA EN ESE CASO
            try
            {
                if (txtIDCliente.Text == "" || txtNombre.Text == "" || txtApellidos.Text == "")
                { MessageBox.Show("FALTAN DATOS"); }
                else
                {
                    ClienteLinq.insertarcliente(txtIDCliente.Text, txtApellidos.Text, txtNombre.Text);
                    this.listarclientes();
                    txtIDCliente.Text = "";
                    txtApellidos.Text = "";
                    txtNombre.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("HA HABIDO UN ERROR");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text == "")
            { MessageBox.Show("FALTAN DATOS"); }
            else
            {
                ClienteLinq.EliminarCliente(txtIDCliente.Text);
                this.listarclientes();
                txtIDCliente.Text = "";
                txtApellidos.Text = "";
                txtNombre.Text = "";
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIDCliente.Text == "") { MessageBox.Show("Falta ID Client"); }
            else
            {
                ClienteLinq.Modificarcliente(txtIDCliente.Text, txtApellidos.Text, txtNombre.Text);
                this.listarclientes();
                txtIDCliente.Text = "";
                txtApellidos.Text = "";
                txtNombre.Text = "";

            }
        }
        void listarclientes()
        {
            GridDatos.DataSource = ClienteLinq.ListarClientes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listarclientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //BUSCA SEGUN EL ELEMENTO MOSTRADO EN EL COMBOBOX
            if (cbSeleccion.Text == "ID Cliente")
            {
                if (txtBuscar.Text == "") { MessageBox.Show("Falta IDCliente"); }
                else { GridDatos.DataSource= ClienteLinq.buscarIDCliente(txtBuscar.Text); }
            }
            else if (cbSeleccion.Text=="Nombre")
            {
                if (txtBuscar.Text == "") { MessageBox.Show("Falta Nombre"); }
                else { GridDatos.DataSource = ClienteLinq.buscarNombre(txtBuscar.Text); }

            }
            else { if (txtBuscar.Text == ""){ MessageBox.Show("Falta Apellido"); }
                else { GridDatos.DataSource = ClienteLinq.buscarApellido(txtBuscar.Text); }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.listarclientes();
            txtIDCliente.Text = "";
            txtApellidos.Text = "";
            txtNombre.Text = "";
            txtBuscar.Text = "";
            cbSeleccion.Text = "ID Cliente";
        }
    }
}
