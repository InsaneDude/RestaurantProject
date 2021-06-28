using System;
using Restaurant.BL.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IChiefMakesOrderService
    {
        int CountingFinalTime(
            ChiefUseInstrument chiefUseInstrument,
            Order order);

        DateTime ChiefIsMakingOrder(
            ChiefUseInstrument chiefUseInstrument, 
            Order orderNow);
    }
}