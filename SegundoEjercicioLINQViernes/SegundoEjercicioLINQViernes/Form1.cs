using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoEjercicioLINQViernes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext bdo = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }
        
        void cargarGrid() 
        {
            var CargaGrid = from e in bdo.empleados
                             select e;
            GridDatos.DataSource = CargaGrid;            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtName.Text == "" || txtSurname.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Falta algún valor");
            }
            else
            {
                empleados MyEmpleado = new empleados();
                MyEmpleado.id = int.Parse(txtID.Text);
                MyEmpleado.nombre = txtName.Text;
                MyEmpleado.apellido = txtSurname.Text;
                MyEmpleado.edad = int.Parse(txtAge.Text);
                bool casao = false;

                if (chkMarried.Checked == true)
                { casao = true; }
                else { }

                MyEmpleado.casado = casao;
                bdo.empleados.InsertOnSubmit(MyEmpleado);
                bdo.SubmitChanges();
                cargarGrid();
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Falta ID");
            }
            else
            {
                empleados MyEmplead = bdo.empleados.Single(q =>
              q.id == int.Parse(txtBuscar.Text));
                bdo.empleados.DeleteOnSubmit(MyEmplead);
                bdo.SubmitChanges();
                cargarGrid();
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Falta algún valor");
            }
            else
            {
                empleados MyEmpleao = bdo.empleados.Single(q =>
             q.id == int.Parse(txtBuscar.Text));
                //MyEmpleao.id = int.Parse(txtID.Text);
                MyEmpleao.nombre = txtName.Text;
                MyEmpleao.apellido = txtSurname.Text;
                MyEmpleao.edad = int.Parse(txtAge.Text);
                bool casao = false;

                if (chkMarried.Checked == true)
                { casao = true; }
                else { }

                MyEmpleao.casado = casao;
                bdo.SubmitChanges();
                cargarGrid();
            }
        }
    }
}
