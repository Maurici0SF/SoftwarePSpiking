using System.Windows;
using System.Windows.Data;
using System.Windows.Shapes;

namespace SoftwarePSpiking
{
    /// <summary>
    /// Lógica de interacción para SpikeVisual.xaml
    /// </summary>
    public partial class SpikeVisual : Window
    {
        public SpikeVisual()
        {
            InitializeComponent();
            DimensionSpike dimensionSpike = new DimensionSpike()
            {
                ICoordX1 =0 ,
                ICoordY1 =50 ,
                ICoordX2 =10,
                ICoordY2 =20,
                DCoordX1 =20,
                DCoordY1 =50,
                DCoordX2 =10,
                DCoordY2 =20
            };
            this.DataContext = dimensionSpike;
        }
    }
}
