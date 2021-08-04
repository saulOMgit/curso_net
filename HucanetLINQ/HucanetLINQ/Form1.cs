using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HucanetLINQ
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
            var cargaGrid = from p in bdo.Enfermo select p;
            GridDatos.DataSource = cargaGrid;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Enfermo MyEnfermo = new Enfermo();
                MyEnfermo.inscripcion = int.Parse(txtInscripcion.Text);
                MyEnfermo.Apellido = txtNomApe.Text;
                string genero;
                if (rdMale.Checked == true) { genero = "M"; }
                else { genero = "F"; }
                MyEnfermo.S = genero;
                MyEnfermo.Fecha_Nac = dtpFecha.Value;
                MyEnfermo.Direccion = txtDire.Text;
                MyEnfermo.NSS = int.Parse(txtNumSS.Text);
                bdo.Enfermo.InsertOnSubmit(MyEnfermo);
                bdo.SubmitChanges();
                cargarGrid();
            }
            catch 
            {
                if (txtInscripcion.Text == "" || txtNomApe.Text == "" || txtDire.Text == ""||txtNumSS.Text=="")
                {
                    MessageBox.Show("Falta algún valor");
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Enfermo MyEnfermo = bdo.Enfermo.Single(p =>
                p.inscripcion == int.Parse(txtInscripcion.Text));
                MyEnfermo.Apellido = txtNomApe.Text;
                string genero;
                if (rdMale.Checked == true) { genero = "M"; }
                else { genero = "F"; }
                MyEnfermo.S = genero;
                MyEnfermo.Fecha_Nac = dtpFecha.Value;
                MyEnfermo.Direccion = txtDire.Text;
                MyEnfermo.NSS = int.Parse(txtNumSS.Text);
                bdo.SubmitChanges();
                cargarGrid();
            }
            catch 
            {
                if (txtInscripcion.Text == "")
                {
                    MessageBox.Show("Falta Inscripcion");
                }
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                Enfermo MyEnfermo = bdo.Enfermo.Single(p =>
                  p.inscripcion == int.Parse(txtInscripcion.Text));
                bdo.Enfermo.DeleteOnSubmit(MyEnfermo);
                bdo.SubmitChanges();
                cargarGrid();
            }
            catch
            {
                if (txtInscripcion.Text == "")
                {
                    MessageBox.Show("Falta Inscripcion");
                }
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NO DISPONIBLE\n14.99$ PARA DESBLOQUEAR");

        }
    }
}
