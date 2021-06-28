using System;
using Restaurant.BL.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IChiefService
    {
        DateTime CountingFinalTime(Order order);
    }
}