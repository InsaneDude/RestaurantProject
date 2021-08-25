using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Restaurant.Models.Annotations;

namespace Restaurant.Models
{
    public class Order : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public Food OrderedFood { get; set; }
        public int OrderedFoodId { get; set; }        
        public DateTime OrderTime { get; set; }
        public Chief ChiefToMakeOrder { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}