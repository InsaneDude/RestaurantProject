using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Restaurant.Models.Annotations;

namespace Restaurant.Models
{
    public class Instrument : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WarmingTime { get; set; }
        public bool IsInstrumentFree { get; set; }
        public DateTime LastUsageTime { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}