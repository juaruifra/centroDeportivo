using CentroDeportivo.ViewModel;
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

namespace CentroDeportivo.View
{
    /// <summary>
    /// Lógica de interacción para SociosWindow.xaml
    /// </summary>
    public partial class SociosWindow : Window
    {
        public SociosWindow()
        {
            InitializeComponent();
            DataContext = new SociosViewModel();
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_DragMove(object sender, MouseButtonEventArgs e)
        {
            // Comprueba que el botón izquierdo está pulsado
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                // Permite arrastrar la ventana
                this.DragMove();
            }
        }

        private void AbrirReservas_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as SociosViewModel;

            // Seguridad básica
            if (vm == null || vm.SocioSeleccionado == null)
                return;

            var reservasVm = new ReservasViewModel(socioId: vm.SocioSeleccionado.Id);

            var ventana = new ReservasWindow
            {
                DataContext = reservasVm
            };

            ventana.Show();
        }



    }
}
