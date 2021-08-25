using System.ComponentModel;
using System.Runtime.CompilerServices;
using Restaurant.Models.Annotations;

namespace Restaurant.Models
{
    public class Chief : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Level { get; set; }
        public bool IsFree { get; set; }
        public Instrument Instrument { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}