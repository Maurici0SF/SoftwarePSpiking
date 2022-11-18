using System.Net.Security;
using System.Windows;
using System.Windows.Controls;

namespace SoftwarePSpiking
{
    public partial class MainWindow : Window
    {
        public int nSpikes;
        public MainWindow()
        {
            InitializeComponent();
            Spikes sss = new Spikes
            {
                NumSpikes = 12
            };
            this.DataContext = sss;
            nSpikes = sss.NumSpikes;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void GrayRectangle_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
        }

        private void BotonPopUp_Click(object sender, RoutedEventArgs e)
        {
            SpikeVisual visualizador = new SpikeVisual(nSpikes);
            visualizador.Show();
        }
    }
}
