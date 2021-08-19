using System.Collections.Generic;
using Restaurant.BLModels.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IMenuService
    {
        List<Food> ShowMenu();
    }
}