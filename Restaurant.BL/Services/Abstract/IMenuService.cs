using System.Collections.Generic;
using Restaurant.BL.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IMenuService
    {
        List<Food> ShowMenu();
    }
}