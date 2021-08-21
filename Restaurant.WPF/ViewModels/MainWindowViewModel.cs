using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL.Services;
using Restaurant.BL.Services.Abstract;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;
using Restaurant.Models;

namespace Restaurant.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IServiceProvider _serviceProvider;

        private Food selectedFoodFromList;
        public RelayCommand MakeOrderRC { get; private set; }
        public ObservableCollection<Food> Foods { get; set; }
        
        public MainWindowViewModel(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            MakeOrderRC = new RelayCommand(obj => MakeOrder());
        }
        
        
        // Foods = new ObservableCollection<FoodModel>();
        // for (int i = 0; i < _serviceProvider.GetService<IMenuService>().ShowMenu().Count; i++)
        // {
        //     Foods.Add( _serviceProvider.GetService<IFoodMapperBLModel>().
        //         convertToModel(_serviceProvider.GetService<IMenuService>().ShowMenu()[i]));
        public Food SelectedFoodFromList
        {
            get => selectedFoodFromList;
            set
            {
                selectedFoodFromList = value;
                OnPropertyChanged("SelectedFoodFromList");
            }
        }
        
        private void MakeOrder()
        {
            if (SelectedFoodFromList == null)
            {
                // _serviceProvider.GetService<IOrderService>().AddOrder(1);
            }
        }
    }
}