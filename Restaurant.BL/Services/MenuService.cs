using System.Collections.Generic;
using Restaurant.BLModels.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Repositories.Interfaces;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;
using Restaurant.WPF.Models;

namespace Restaurant.BL.Services
{
    public class MenuService : IMenuService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFoodMapper _foodMapper;

        public MenuService(
            IUnitOfWork unitOfWork, IFoodMapper foodMapper)
        {
            _unitOfWork = unitOfWork;
            _foodMapper = foodMapper;
        }
        public List<Food> ShowMenu()
        {
            List<Food> Menu = new List<Food>();
            foreach (var foodNow in _unitOfWork.FoodRepository.GetAll())
            {
                Menu.Add(_foodMapper.convertToModel(foodNow));
            }
            return Menu;
            // TODO LINQ в 1 лінію
        }
    }
}