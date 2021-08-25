using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using Restaurant.BL.Services.Abstract;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;
using Restaurant.Models;

namespace Restaurant.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IOrderService _orderService;
        private readonly IMenuService _menuService;
        private readonly IChiefService _chiefService;
        
        public RelayCommand MakeOrderRC { get; private set; }

        private Food _selectedFoodFromList;
        public ObservableCollection<Food> _foodOC;
        
        public ObservableCollection<Food> FoodOC
        {
            get => _foodOC;
            set => _foodOC = value;
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

        public MainWindowViewModel(
            IOrderService orderService,
            IMenuService menuService,
            IChiefService chiefService)
        {
            _orderService = orderService;
            _menuService = menuService;
            _chiefService = chiefService;
            
            MakeOrderRC = new RelayCommand(obj => MakeOrder());
            FoodOC = new ObservableCollection<Food>();
            AddToOC(_menuService.ShowMenu());
        }
        
        private void MakeOrder()
        {
            if (SelectedFoodFromList != null)
            {
                _orderService.AddOrder(_selectedFoodFromList.Id);
                MessageBox.Show($"Заказ будет выполнен в {_chiefService.CountingFinalTime(_orderService.AddOrder(_selectedFoodFromList.Id))}", "Результат заказа");
            }
        }
        private void AddToOC(List<Food> foods)
        {
            foreach (var foodNow in foods)
            {
                FoodOC.Add(foodNow);
            }
        }
    }
}