using System.Net.Security;
using System.Windows;

namespace SoftwarePSpiking
{
    public partial class MainWindow : Window 
    {

        public MainWindow()
        {
            InitializeComponent();
            Spikes sss = new Spikes
            {
                NumSpikes = 12
            };
            this.DataContext = sss;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void GrayRectangle_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
        }

        private void BotonPopUp_Click(object sender, RoutedEventArgs e)
        {
            SpikeVisual visualizador = new SpikeVisual();
            visualizador.Show();
        }
    }
}
