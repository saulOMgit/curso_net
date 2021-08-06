using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Entity_Framework_Database_First
{
    /// <summary>
    /// Lógica de interacción para VentanaInsertar.xaml
    /// </summary>
    public partial class VentanaInsertar : Window
    {
        EscuelaEntities DbEntityes = new EscuelaEntities();
        public VentanaInsertar()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int idulti = MyDataGrid.Items.Count+1;
            Profesores MyProfe = new Profesores()
            {
                Id = int.Parse(TxtID.Text),
                Nombre = TxtNombre.Text,
                Especialidad = cmbEspec.Text
            };
            DbEntityes.Profesores.Add(MyProfe);
            DbEntityes.SaveChanges();
            MainWindow.ControlDatagrid.ItemsSource = DbEntityes.Profesores.ToList();
            this.Hide();
        }

        }
    }

