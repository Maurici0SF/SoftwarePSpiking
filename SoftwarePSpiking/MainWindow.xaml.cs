using System.Net.Security;
using System.Windows;
using System.Windows.Controls;

namespace SoftwarePSpiking
{
    public partial class MainWindow : Window
    {
        //public string sSpikes;
        public int a;
        public MainWindow()
        {
            InitializeComponent();
            Spikes sss = new Spikes
            {
                NumSpikes = 3
            };
            this.DataContext = sss;
            //sSpikes = sss.SnumSpikes;
            a = sss.NumSpikes;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void GrayRectangle_TextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
        }

        private void BotonPopUp_Click(object sender, RoutedEventArgs e)
        {
            SpikeVisual visualizador = new SpikeVisual(a);
            visualizador.Show();
        }
    }
}
