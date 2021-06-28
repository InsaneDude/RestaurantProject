using System.Collections.Generic;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.BL.Services
{
    public class MenuService : IMenuService
    {
        private IUnitOfWork _unitOfWork;
        private IFoodMapper _foodMapper;

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
        }
    }
}