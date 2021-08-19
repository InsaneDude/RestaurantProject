using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Extensions.DependencyInjection;
using Restaurant.BL.Services;
using Restaurant.BL.Services.Abstract;
using Restaurant.WPF.Models;
using Restaurant.Mappers.MapperBLToModel.Interfaces;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;

namespace Restaurant.WPF.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly IServiceProvider _serviceProvider;

        private FoodModel selectedFoodFromList;
        public RelayCommand MakeOrderRC { get; private set; }
        public ObservableCollection<FoodModel> Foods { get; set; }
        
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
        public FoodModel SelectedFoodFromList
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
                _serviceProvider.GetService<IOrderService>().AddOrder(1);
            }
        }
    }
}