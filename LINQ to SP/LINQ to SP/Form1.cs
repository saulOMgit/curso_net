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
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ClienteLinq.Modificarcliente(txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteLinq.EliminarCliente(txtNombre.Text);
        }
    }
}
