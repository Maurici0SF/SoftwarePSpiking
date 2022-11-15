using System.ComponentModel;

namespace SoftwarePSpiking
{
    public class DimensionSpike : INotifyPropertyChanged
    {
        private int icoordX1; 
        private int icoordY1;
        private int icoordX2;
        private int icoordY2;
        private int dcoordX1;
        private int dcoordY1;
        private int dcoordX2;
        private int dcoordY2;
        //public int ciclosParaSpike;
        public int ICoordX1
        {
            get { return icoordX1; }
            set 
            { 
                icoordX1 = value;
                OnPropertyChanged("ICoordX1");
            }
        }

        public int ICoordY1  //cte
        {
            get { return icoordY1; }
            set 
            { 
                icoordY1 = value;
                OnPropertyChanged("ICoordY1");
            }
        }

        public int ICoordX2
        {
            get { return icoordX2; }
            set 
            { 
                icoordX2 = value;
                OnPropertyChanged("ICoordX2");
            }
        }

        public int ICoordY2  //cte
        { 
            get { return icoordY2; }
            set 
            { 
                icoordY2 = value;
                OnPropertyChanged("ICoordY2");
            }
        }

        public int DCoordX1
        {
            get { return dcoordX1; }
            set 
            { 
                dcoordX1 = value;
                OnPropertyChanged("DCoordX1");
            }
        }

        public int DCoordY1
        {
            get { return dcoordY1; }
            set 
            {
                dcoordY1 = value; 
                OnPropertyChanged("DCoordY1");
            }
        }

        public int DCoordX2
        {
            get { return dcoordX2; }
            set
            { 
                dcoordX2 = value;
                OnPropertyChanged("DCoordX2");
            }
        }

        public int DCoordY2
        {
            get { return dcoordY2; }
            set 
            { 
                dcoordY2 = value;
                OnPropertyChanged("DCoordY2");
            }
        }

        //public int CiclosParaSpike
        //{
        //    get { return ciclosParaSpike; }
        //    set { ciclosParaSpike = value; }
        //}

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

        //public void SetValueNumSpikes(Spikes spikes)
        //{
        //    CiclosParaSpike = spikes.NumSpikes;
        //}
    }
}
