using System.Net.Security;
using System.Windows;

namespace SoftwarePSpiking
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Spikes sss = new Spikes
            {
                NumSpikes = 120
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

            //Window1 window1 = new Window1();
            //window1.Show();

            //for (int i = 0; i < int.Parse(SpikeCounter.Text); i++)
            //{
            //    PathGeometry Unicospike = new PathGeometry();
            //    Unicospike = spikesVisual.UniqueSpike;
            //    Canvas.SetLeft(Unicospike, 180);
            //    Canvas.SetTop(Unicospike, 190);
            //}
        }
    }
}
