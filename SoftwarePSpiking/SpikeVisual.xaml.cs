using Hangfire.Annotations;
using System.Windows;

namespace SoftwarePSpiking
{
    /// <summary>
    /// Lógica de interacción para SpikeVisual.xaml
    /// </summary>
    public partial class SpikeVisual : Window
    {
        public int nSpikes;
        public SpikeVisual(int NumeroSpikes)
        {
            
            InitializeComponent();
            DimensionSpike dimensionSpike = new DimensionSpike()
            {
                ICoordX1 =0,
                ICoordY1 =50,
                ICoordX2 =10,
                ICoordY2 =20,
                DCoordX1 =20,
                DCoordY1 =50,
                DCoordX2 =10,
                DCoordY2 =20
            };
            this.DataContext = dimensionSpike;
            nSpikes = NumeroSpikes;
            //this.DataContext = this;
        }

    }
}
