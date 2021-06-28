using System;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Entities;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.BL.Services
{
    public class ChiefMakesOrderService : IChiefMakesOrderService
    {
        private IUnitOfWork _unitOfWork;
        private IOrderMapper _orderMapper;
        private IChiefUseInstrumentMapper _chiefUseInstrumentMapper;

        public ChiefMakesOrderService(
            IUnitOfWork unitOfWork,
            IOrderMapper orderMapper,
            IChiefUseInstrumentMapper chiefUseInstrumentMapper)
        {
            _unitOfWork = unitOfWork;
            _orderMapper = orderMapper;
            _chiefUseInstrumentMapper = chiefUseInstrumentMapper;
        }

        public int CountingFinalTime(
            ChiefUseInstrument chiefUseInstrument,
            Order order)
        {
            int finalCookingTime;
            finalCookingTime = (order.OrderedFood[0].CookingTime / chiefUseInstrument.Chief.Level) +
                               chiefUseInstrument.Instrument.WarmingTime;
            return finalCookingTime;
        }

        public DateTime ChiefIsMakingOrder(ChiefUseInstrument chiefUseInstrument, Order orderNow)
        {
            chiefUseInstrument.Chief.IsFree = true;
            DateTime orderBeReady = DateTime.Now.AddSeconds(CountingFinalTime(chiefUseInstrument, orderNow));
            _unitOfWork.OrderRepository.Delete(orderNow.Id);
            return orderBeReady;
        }
        // public bool FoodReady { get; set; }

    }
}