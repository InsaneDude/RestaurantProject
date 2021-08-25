using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Restaurant.BL.Services.Abstract;
using Restaurant.Models;

namespace Restaurant.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IOrderService _orderService;
        private readonly IMenuService _menuService;
        public RelayCommand MakeOrderRC { get; private set; }

        private Food _selectedFoodFromList;
        private Order _order;
        private string _messageToShow;
        private List<Food> _foodOC;
        
        public List<string> TestOC { get; set; }
        public string test { get; set; }
        // public ObservableCollection<OrderModel> Orders =>
        //     new(_orderService.GetAllOrders());
            
        public List<Food> FoodOC
        {
            get => _foodOC;
            set => _foodOC = value;
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
        
        public MainWindowViewModel(
            IOrderService orderService,
            IMenuService menuService)
        {
            _orderService = orderService;
            _menuService = menuService;
            MakeOrderRC = new RelayCommand(obj => MakeOrder());
            test = "testing";
            // TestOC = new ObservableCollection<string> {"test1", "test2"};
            var foods = _menuService.ShowMenu();
            FoodOC = foods;
            // FoodOC = new ObservableCollection<Food>(new Food[]{new Food(){Name = "apo"}});
            // FoodOC = new ObservableCollection<Food>(_menuService.ShowMenu());
            // menuService.ShowMenu().ForEach(foodNow => FoodOC.Add(foodNow));
        }
        
        private void MakeOrder()
        {
            if (SelectedFoodFromList == null)
            {
                _orderService.AddOrder(_selectedFoodFromList.Id);
            }
        }
    }
}