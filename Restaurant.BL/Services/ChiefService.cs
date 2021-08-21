using System;
using System.Linq;
using Restaurant.BL.Services.Abstract;
using Restaurant.Models;
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
            Chief chiefToFind = _chiefMapper.convertToModel(_unitOfWork.ChiefRepository
                .GetAll()
                .FirstOrDefault(freeChief => freeChief.IsFree is true));
            chiefToFind.IsFree = false;
            return chiefToFind;
        }
        
        private Chief ChiefSelectsInstrument()
        {
            Chief chiefToGiveInstrument = ChiefSelecting();
            chiefToGiveInstrument.Instrument = _instrumentMapper.convertToModel(_unitOfWork.InstrumentRepository
                .GetAll()
                .FirstOrDefault(freeInstr => freeInstr.IsInstrumentFree is true));
            chiefToGiveInstrument.Instrument.IsInstrumentFree = false;
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
            // TODO посмотреть апдейт
            // _unitOfWork.ChiefRepository.Update(_chiefMapper.convertToEntity(chiefToOperate));
            // _unitOfWork.Save();
            return orderBeReady;
        }
    }
}