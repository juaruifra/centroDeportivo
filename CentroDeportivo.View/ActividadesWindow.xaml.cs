using CentroDeportivo.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace CentroDeportivo.View
{
    public partial class ActividadesWindow : Window
    {
        public ActividadesWindow()
        {
            InitializeComponent();
            DataContext = new ActividadesViewModel();
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_DragMove(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
    }
}
