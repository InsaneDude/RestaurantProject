using System;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.BL.Services
{
    public class ChiefService : IChiefService
    {
        private IUnitOfWork _unitOfWork;
        private IChiefMapper _chiefMapper;
        private IInstrumentMapper _instrumentMapper;
        private IInstrumentService _instrumentService;
        private IOrderMapper _orderMapper;

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
            if (order.OrderedFood.FoodNeedInstrument is true)
            {
                finalCookingTime = (order.OrderedFood.CookingTime / chiefToOperate.Level) +
                                   _instrumentService.InstrumentWarmingChecker(chiefToOperate.Instrument);
            }
            else
            {
                finalCookingTime = order.OrderedFood.CookingTime / chiefToOperate.Level;
            }
            DateTime orderBeReady = DateTime.Now.AddSeconds(finalCookingTime);
            // TODO добавить проверку когда можно освободить
            // TODO пофиксить записи в таблицу
            chiefToOperate.IsFree = true;
            chiefToOperate.Instrument.IsInstrumentFree = true;
            chiefToOperate.Instrument = null;
            return orderBeReady;
        }
    }
}