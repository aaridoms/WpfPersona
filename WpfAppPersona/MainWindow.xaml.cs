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

namespace WpfAppPersona
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // Botón utilizado para abrir la ventana de creacion de personas.
            Window1 w = new Window1();
            w.Show();
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            // Botón para salir de la aplicación.
            MainWindow w = new MainWindow();
            MessageBox.Show("Gracias por usar el programa :)");
            this.Close();
        }

        private void menu2_Click(object sender, RoutedEventArgs e)
        {
            // Botón utilizado para abrir la ventana de consulta.
            Window2 w = new Window2();
            w.Show();
        }
    }
}
