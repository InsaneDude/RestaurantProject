using System.ComponentModel;
using System.Runtime.CompilerServices;
using Restaurant.Models.Annotations;

namespace Restaurant.Models
{
    public class Food : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Weight { get; set; }
        public int CookingTime { get; set; }
        public string Ingredients { get; set; }
        public bool FoodNeedInstrument { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}