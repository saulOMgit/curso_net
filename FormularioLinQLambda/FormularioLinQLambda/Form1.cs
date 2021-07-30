using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioLinQLambda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataClasses1DataContext Norwin = new DataClasses1DataContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
            cargarGrid();
        }

        void cargarCombo() 
        {
            var CargaCombo = from p in Norwin.Products
                             select p.ProductName;
            comboBox1.DataSource = CargaCombo;
        }
        void cargarGrid() 
        {
            var cargaGrid = from p in Norwin.Products select p;
            GridDatos.DataSource = cargaGrid;
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Products MyProduct = new Products();
            MyProduct.ProductName = txtProd.Text;
            MyProduct.UnitPrice = int.Parse(txtPrec.Text);
            MyProduct.UnitsInStock = short.Parse(txtStock.Text);
            MyProduct.CategoryID = int.Parse(txtCat.Text);
            Norwin.Products.InsertOnSubmit(MyProduct);
            Norwin.SubmitChanges();
            cargarGrid();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            Products MyProducto = Norwin.Products.Single(p => 
            p.ProductName == comboBox1.SelectedItem.ToString());
            MyProducto.ProductName = comboBox1.SelectedItem.ToString();
            MyProducto.UnitPrice = int.Parse(txtPrec.Text);
            MyProducto.UnitsInStock = short.Parse(txtStock.Text);
            MyProducto.CategoryID = int.Parse(txtCat.Text);
            Norwin.SubmitChanges();
            cargarGrid();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Products MyProduct = Norwin.Products.Single(p =>
             p.ProductName == comboBox1.SelectedItem.ToString());
            Norwin.Products.DeleteOnSubmit(MyProduct);
            Norwin.SubmitChanges();
        }
    }
}
