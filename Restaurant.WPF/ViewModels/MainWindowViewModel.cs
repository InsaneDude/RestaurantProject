using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Restaurant.BL.Services.Abstract;
using Restaurant.Models;

namespace Restaurant.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly IOrderService _orderService;
        private readonly IMenuService _menuService;
        public RelayCommand MakeOrderRC { get; private set; }

        private List<Food> _foods;
        private Food _selectedFoodFromList;
        private Order _order;
        private string _messageToShow;
        private ObservableCollection<Food> _foodOC { get; set; }

        public MainWindowViewModel(
            IServiceProvider serviceProvider,
            IOrderService orderService,
            IMenuService menuService)
        {
            _serviceProvider = serviceProvider;
            _orderService = orderService;
            _menuService = menuService;
            MakeOrderRC = new RelayCommand(obj => MakeOrder());
            // menuService.ShowMenu().ForEach(foodNow => Foods.Add(foodNow));
        }

        public ObservableCollection<Food> FoodOC
        {
            get => FoodOC;
            set
            {
                _foodOC = new ObservableCollection<Food>(_menuService.ShowMenu());
            }
        }

        public string MessageToShow
        {
            get => _messageToShow;
            set
            { 
                _messageToShow = value;
                OnPropertyChanged(MessageToShow);
            }
        }

        public List<Food> Foods
        {
            get => _foods;
            set
            {
                _foods = value;
                OnPropertyChanged("Foods");
            }
        }

        public Food SelectedFoodFromList
        {
            get => _selectedFoodFromList;
            set
            {
                _selectedFoodFromList = value;
                OnPropertyChanged("SelectedFoodFromList");
            }
        }

        public Order OrderToMake
        {
            get => _order;
            set
            {
                _order = value;
                OnPropertyChanged("OrderToMake");
            }
        }

        private void MakeOrder()
        {
            // if (SelectedFoodFromList == null)
            // {
            //     _orderService.AddOrder(_selectedFoodFromList.Id);
            // }
        }
    }
}