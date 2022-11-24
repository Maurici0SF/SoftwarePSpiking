using Hangfire.Annotations;
using System.Collections.Generic;
using System.Net;
using System.Windows;
using System.Windows.Documents;

namespace SoftwarePSpiking
{
    /// <summary>
    /// Lógica de interacción para SpikeVisual.xaml
    /// </summary>
    public partial class SpikeVisual : Window
    {
        //public int IrecorredorX1;
        //public int IrecorredorX2;
        //public int DrecorredorX1;
        //public int DrecorredorX2;
        public int recorredorX;
        public List<DimensionSpike> cantidadSpikes { get; set; }

        public SpikeVisual(int a)
        {
            recorredorX = 0;
            //IrecorredorX1 = 0;
            //IrecorredorX2 = 0;
            //DrecorredorX1 = 0;
            //DrecorredorX2 = 0;
            InitializeComponent();
            //Generador de spikes con n cantidad solicitada
            //List<DimensionSpike> cantidadSpikes = new List<DimensionSpike>(a);
            for (int i = 0; i < a; i++)
            {
                cantidadSpikes = new List<DimensionSpike>
                {
                    new DimensionSpike
                    {
                        ICoordX1 = 0 + recorredorX,
                        ICoordY1 = 50,
                        ICoordX2 = 10 + recorredorX,
                        ICoordY2 = 20,
                        DCoordX1 = 20 + recorredorX,
                        DCoordY1 = 50,
                        DCoordX2 = 10 + recorredorX,
                        DCoordY2 = 20
                    }
                };
                //cantidadSpikes.Add(new DimensionSpike()
                //{
                //    ICoordX1 = 0 + recorredorX,
                //    ICoordY1 = 50,
                //    ICoordX2 = 10 + recorredorX,
                //    ICoordY2 = 20,
                //    DCoordX1 = 20 + recorredorX,
                //    DCoordY1 = 50,
                //    DCoordX2 = 10 + recorredorX,
                //    DCoordY2 = 20
                //};

                recorredorX += 20;
                //this.DataContext = cantidadSpikes;
            }


            //for (int i = 0; i < a; i++)
            //{
            //    DimensionSpike dimensionSpike = new DimensionSpike()
            //    {
            //        ICoordX1 = 0,
            //        ICoordY1 = 50,
            //        ICoordX2 = 10,
            //        ICoordY2 = 20,
            //        DCoordX1 = 20,
            //        DCoordY1 = 50,
            //        DCoordX2 = 10,
            //        DCoordY2 = 20
            //    };
            //    this.DataContext = dimensionSpike;
            //}
            //DimensionSpike dimensionSpike = new DimensionSpike()
            //{
            //    ICoordX1 =0,
            //    ICoordY1 =50,
            //    ICoordX2 =10,
            //    ICoordY2 =20,
            //    DCoordX1 =20,
            //    DCoordY1 =50,
            //    DCoordX2 =10,
            //    DCoordY2 =20
            //};


        }

    }
}
