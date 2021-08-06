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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Entity_Framework_Database_First
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EscuelaEntities DbEntityes = new EscuelaEntities();
        public static DataGrid ControlDatagrid;

        public MainWindow()
        {
            //Cargamos el Datagrid con los datos
            InitializeComponent();
            MyDG.ItemsSource = DbEntityes.Profesores.ToList();
            ControlDatagrid = MyDG;
        }

        private void MyDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //el primer botón llama al cuadro Insertar
            VentanaInsertar Vinsertar = new VentanaInsertar();
            Vinsertar.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //El segundo botón llama al cuadro modificar
            int id = (MyDG.SelectedItem as Profesores).Id;
            VentanaModificar Vcambiar = new VentanaModificar(id);
            Vcambiar.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //eliminar
            int id = (MyDG.SelectedItem as Profesores).Id;
            var deleteProfe = DbEntityes.Profesores.Where(m =>
              m.Id == id).Single();
            DbEntityes.Profesores.Remove(deleteProfe);
            DbEntityes.SaveChanges();
            ControlDatagrid.ItemsSource =
                DbEntityes.Profesores.ToList();
        }
    }
}
