using System;
using Restaurant.BLModels.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Repositories.Interfaces;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;

namespace Restaurant.BL.Services
{
    public class ChiefService : IChiefService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IChiefMapper _chiefMapper;
        private readonly IInstrumentMapper _instrumentMapper;
        private readonly IInstrumentService _instrumentService;
        private readonly IOrderMapper _orderMapper;

        public ChiefService(
            IUnitOfWork unitOfWork, 
            IChiefMapper chiefMapper,
            IInstrumentMapper instrumentMapper, 
            IInstrumentService instrumentService,
            IOrderMapper orderMapper)
        {
            _unitOfWork = unitOfWork;
            _chiefMapper = chiefMapper;
            _instrumentMapper = instrumentMapper;
            _instrumentService = instrumentService;
            _orderMapper = orderMapper;
        }

        private Chief ChiefSelecting()
        {
            Chief chiefToFind = new Chief();
            foreach (var chiefNow in _unitOfWork.ChiefRepository.GetAll())
            {
                if (chiefNow.IsFree is true)
                {
                    chiefToFind = _chiefMapper.convertToModel(chiefNow);
                    chiefToFind.IsFree = false;
                    break;
                }
                // TODO query FoD
            }
            return chiefToFind;
        }
        
        private Chief ChiefSelectsInstrument()
        {
            Chief chiefToGiveInstrument = ChiefSelecting();
            foreach (var instrumentNow in _unitOfWork.InstrumentRepository.GetAll())
            {
                if (instrumentNow.IsInstrumentFree is true)
                {
                    chiefToGiveInstrument.Instrument = _instrumentMapper.convertToModel(instrumentNow);
                    chiefToGiveInstrument.Instrument.IsInstrumentFree = false;
                    break;
                }
            }
            return chiefToGiveInstrument;
        }

        public DateTime CountingFinalTime(Order order)
        {
            Chief chiefToOperate = ChiefSelectsInstrument();
            int finalCookingTime;
            order.ChiefToMakeOrder = chiefToOperate;
            _unitOfWork.OrderRepository.Add(_orderMapper.convertToEntity(order));
            if (order.OrderedFood.FoodNeedInstrument)
            {
                finalCookingTime = (order.OrderedFood.CookingTime / chiefToOperate.Level) +
                                   _instrumentService.InstrumentWarmingChecker(chiefToOperate.Instrument);
            }
            else
            {
                finalCookingTime = order.OrderedFood.CookingTime / chiefToOperate.Level;
            }
            DateTime orderBeReady = DateTime.Now.AddSeconds(finalCookingTime);
            chiefToOperate.IsFree = true;
            chiefToOperate.Instrument.IsInstrumentFree = true;
            chiefToOperate.Instrument = null;
            _unitOfWork.ChiefRepository.Update(_chiefMapper.convertToEntity(chiefToOperate));
            _unitOfWork.Save();
            // TODO transactions check
            return orderBeReady;
        }
    }
}