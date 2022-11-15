
using System;
using System.ComponentModel;

namespace SoftwarePSpiking
{
    public class Spikes : INotifyPropertyChanged
    {

        private int numSpikes;

        public int NumSpikes
        {
            get { return numSpikes; }
            set 
            { 
                numSpikes = value;
                OnPropertyChanged(nameof(NumSpikes));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(String info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
    

}
