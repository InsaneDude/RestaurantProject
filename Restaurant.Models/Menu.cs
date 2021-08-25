using System.ComponentModel;
using System.Runtime.CompilerServices;
using Restaurant.Models.Annotations;

namespace Restaurant.Models
{
    public class Menu : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public Food Food { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}