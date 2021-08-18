using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso_Agosto_2_Entity
{
    public partial class Form1 : Form
    {
        Repaso_AgostoEntities ClientesEntity = new Repaso_AgostoEntities();
        public Form1()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid() 
        {
        GridDatos.DataSource=ClientesEntity.Clientes.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Clientes Misclientes = new Clientes()
            {
                DNI = txtDNI.Text,
                Nombre = txtNombre.Text,
                Apellidos = txtApellidos.Text,
                Estado_Civil = cbEstadoCivil.Text,
                Email = txtEmail.Text,
                Telefono = txtTelefono.Text,
                Fecha_Nacimiento = dtpFechaNaci.Value
            };
            ClientesEntity.Clientes.Add(Misclientes);
            ClientesEntity.SaveChanges();
            CargarGrid();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String TextoDNI = txtDNI.Text;
            var deleteCliente = ClientesEntity.Clientes.Where(c => c.DNI == TextoDNI).Single();
            ClientesEntity.Clientes.Remove(deleteCliente);
            ClientesEntity.SaveChanges();
            CargarGrid();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String TextoDNI = txtDNI.Text;
            Clientes MyCliente = (from c in ClientesEntity.Clientes where c.DNI == TextoDNI select c).Single();

            MyCliente.Nombre = txtNombre.Text;
            MyCliente.Apellidos = txtApellidos.Text;
            MyCliente.Email = txtEmail.Text;
            MyCliente.Telefono = txtTelefono.Text;
            MyCliente.Estado_Civil = cbEstadoCivil.Text;
            MyCliente.Fecha_Nacimiento = dtpFechaNaci.Value;
            ClientesEntity.SaveChanges();            
            CargarGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
