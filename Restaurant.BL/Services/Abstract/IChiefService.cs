using System;
using Restaurant.BLModels.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IChiefService
    {
        DateTime CountingFinalTime(Order order);
    }
}