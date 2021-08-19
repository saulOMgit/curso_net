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
        //DEFINIR UN EVENTO PARA CARGAR EL GRID
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
            //LLAMAMOS AL CONTEXTO DE ENTIDADES Y AÑADIMOS AL OBJETO CLIENTE
            ClientesEntity.Clientes.Add(Misclientes);
            //GUARDAR EL NUEVO REGISTRO EN LA BASE DE DATOS
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
            //DEFINIR UNA VARIABLE PARA EL DNI, OJO DEBERIA ESTAR CONTROLADO
            String TextoDNI = txtDNI.Text;
            //MEDIANTE LINQ OBTENEMOS EL CLIENTE
            Clientes MyCliente = (from c in ClientesEntity.Clientes where c.DNI == TextoDNI select c).Single();

            //DEFINIMOS LOS ATRIBUTOS DEL BOJETO MyCLIENTE
            
            MyCliente.Nombre = txtNombre.Text;
            MyCliente.Apellidos = txtApellidos.Text;
            MyCliente.Email = txtEmail.Text;
            MyCliente.Telefono = txtTelefono.Text;
            MyCliente.Estado_Civil = cbEstadoCivil.Text;
            MyCliente.Fecha_Nacimiento = dtpFechaNaci.Value;
            //HACEMOS SALVADO EN LA BBDD
            ClientesEntity.SaveChanges();            
            CargarGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String TextoDNI = txtDNI.Text;

            var BuscarCliente = ClientesEntity.Clientes.Where(c => c.DNI == TextoDNI).Single();
            txtNombre.Text= BuscarCliente.Nombre;
            txtApellidos.Text = BuscarCliente.Apellidos;
            txtEmail.Text = BuscarCliente.Email;
            txtTelefono.Text = BuscarCliente.Telefono;
            cbEstadoCivil.Text = BuscarCliente.Estado_Civil;
            dtpFechaNaci.Text = BuscarCliente.Fecha_Nacimiento.ToString();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            String TextoDNI = txtDNI.Text;

            var BuscarCliente = ClientesEntity.Clientes.First();
            txtDNI.Text = BuscarCliente.DNI;
            txtNombre.Text = BuscarCliente.Nombre;
            txtApellidos.Text = BuscarCliente.Apellidos;
            txtEmail.Text = BuscarCliente.Email;
            txtTelefono.Text = BuscarCliente.Telefono;
            cbEstadoCivil.Text = BuscarCliente.Estado_Civil;
            dtpFechaNaci.Text = BuscarCliente.Fecha_Nacimiento.ToString();
        }

        private void btnmuyalante_Click(object sender, EventArgs e)
        {
            String TextoDNI = txtDNI.Text;

            var BuscarCliente = ClientesEntity.Clientes.ToList().Last();
            txtDNI.Text = BuscarCliente.DNI;
            txtNombre.Text = BuscarCliente.Nombre;
            txtApellidos.Text = BuscarCliente.Apellidos;
            txtEmail.Text = BuscarCliente.Email;
            txtTelefono.Text = BuscarCliente.Telefono;
            cbEstadoCivil.Text = BuscarCliente.Estado_Civil;
            dtpFechaNaci.Text = BuscarCliente.Fecha_Nacimiento.ToString();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA ANTERIOR
                int anterior = GridDatos.CurrentRow.Index - 1;

                //NOS DESPLAZAMOS A LA FILA ANTERIOR
                GridDatos.CurrentCell = GridDatos.Rows[anterior].Cells[GridDatos.CurrentCell.ColumnIndex];

                //AQUI CARGAMOS EN EL TEXTBOX EL DNI
                txtDNI.Text = GridDatos.Rows[anterior].Cells[0].Value.ToString();
                txtNombre.Text = GridDatos.Rows[anterior].Cells[1].Value.ToString();
                txtApellidos.Text = GridDatos.Rows[anterior].Cells[2].Value.ToString();
                cbEstadoCivil.Text = GridDatos.Rows[anterior].Cells[3].Value.ToString();
                txtTelefono.Text = GridDatos.Rows[anterior].Cells[4].Value.ToString();
                txtEmail.Text = GridDatos.Rows[anterior].Cells[5].Value.ToString();
                dtpFechaNaci.Text = GridDatos.Rows[anterior].Cells[6].Value.ToString();
            }
            catch { MessageBox.Show("No existen registros previos"); }
        }

        private void btnadelante_Click(object sender, EventArgs e)
        {
            try
            {
                //DECLARAMOS UNA VARIABLE PARA INDICAR LA FILA SIGUIENTE
                int siguiente = GridDatos.CurrentRow.Index + 1;

                //NOS DESPLAZAMOS A LA FILA ANTERIOR
                GridDatos.CurrentCell = GridDatos.Rows[siguiente].Cells[GridDatos.CurrentCell.ColumnIndex];

                //AQUI CARGAMOS EN EL TEXTBOX EL DNI
                txtDNI.Text = GridDatos.Rows[siguiente].Cells[0].Value.ToString();
                txtNombre.Text = GridDatos.Rows[siguiente].Cells[1].Value.ToString();
                txtApellidos.Text = GridDatos.Rows[siguiente].Cells[2].Value.ToString();
                cbEstadoCivil.Text = GridDatos.Rows[siguiente].Cells[3].Value.ToString();
                txtTelefono.Text = GridDatos.Rows[siguiente].Cells[4].Value.ToString();
                txtEmail.Text = GridDatos.Rows[siguiente].Cells[5].Value.ToString();
                dtpFechaNaci.Text = GridDatos.Rows[siguiente].Cells[6].Value.ToString();
            }
            catch { MessageBox.Show("No hay más registros"); }


        }
    }
}
