using System.Windows;
using Restaurant.BL.Services.Abstract;
using Restaurant.WPF.Models;

namespace Restaurant.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IOrderService _orderService;
        private readonly IMenuService _menuService;
        private readonly IChiefService _chiefService;
        private readonly IInstrumentService _instrumentService;
        
        // public RelayCommand MakeOrder { get; private set; }

        public MainWindowViewModel(
            IOrderService orderService, IChiefService chiefService,
            IMenuService menuService, IInstrumentService instrumentService)
        {
            _orderService = orderService;
            _chiefService = chiefService;
            _menuService = menuService;
            _instrumentService = instrumentService;
        }

        public FoodModel SelectedFoodFromList
        {
            get => SelectedFoodFromList;
            set
            {
                SelectedFoodFromList = value;
                OnPropertyChanged("SelectedFoodFromList");
            }
        }
        
        private void MakeOrder()
        {
            if (SelectedFoodFromList == null)
            {
                _orderService.AddOrder(1);st
            }
        }
        // MakeOrderCommand = new RelayCommand(obj => MakeOrder());
    }
}