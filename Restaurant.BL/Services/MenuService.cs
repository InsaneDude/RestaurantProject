using System.Collections.Generic;
using System.Linq;
using Restaurant.BL.Services.Abstract;
using Restaurant.Models;
using Restaurant.DAL.Repositories.Interfaces;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;

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
            // var FoodTest = _unitOfWork.FoodRepository.GetAll();
            // FoodTest.ForEach(foodNow => Menu.Add(_foodMapper.convertToModel(foodNow)));
            _unitOfWork.FoodRepository.GetAll().ForEach(foodNow => Menu.Add(_foodMapper.convertToModel(foodNow)));
            return Menu;
        }
    }
}