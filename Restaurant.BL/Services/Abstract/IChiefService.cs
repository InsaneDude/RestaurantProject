using System;
using Restaurant.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IChiefService
    {
        DateTime CountingFinalTime(Order order);
    }
}