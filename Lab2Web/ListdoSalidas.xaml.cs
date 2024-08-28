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

namespace Lab2Web
{
    /// <summary>
    /// Lógica de interacción para ListdoSalidas.xaml
    /// </summary>
    public partial class ListdoSalidas : Window
    {
        public ListdoSalidas()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            string fechaInicio = FechaInicioTextBox.Text;
            string fechaFin = FechaFinTextBox.Text;
        }
    }
}
