using System.Collections.Generic;
using Restaurant.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IMenuService
    {
        List<Food> ShowMenu();
    }
}