using System.Windows;

namespace Lab2Web
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OperacionesIngresos_Click(object sender, RoutedEventArgs e)
        {
            RegistroSalidaWindow ingresosWindow = new RegistroSalidaWindow();
            ingresosWindow.Show();
        }

        private void OperacionesSalidas_Click(object sender, RoutedEventArgs e)
        {
            RegistroSalidaWindow registroSalidaWindow = new RegistroSalidaWindow();
            registroSalidaWindow.Show();
        }

        private void MantenimientoConductores_Click(object sender, RoutedEventArgs e)
        {
            RegistroConductores conductoresWindow = new RegistroConductores();
            conductoresWindow.Show();
        }

        private void RegistroConductores_Click(object sender, RoutedEventArgs e)
        {
            RegistroConductores conductoresWindow = new RegistroConductores();
            conductoresWindow.Show();
        }

        private void MantenimientoCamiones_Click(object sender, RoutedEventArgs e)
        {
            RegistroCamiones camionesWindow = new RegistroCamiones();
            camionesWindow.Show();
        }

        


        private void ReportesSalidas_Click(object sender, RoutedEventArgs e)
        {
            ListdoSalidas listadoSalidasWindow = new ListdoSalidas();
            listadoSalidasWindow.Show();
        }
    }
}
