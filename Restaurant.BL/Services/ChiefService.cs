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

        public ChiefService(
            IUnitOfWork unitOfWork, IChiefMapper chiefMapper,
            IInstrumentMapper instrumentMapper, IInstrumentService instrumentService)
        {
            _unitOfWork = unitOfWork;
            _chiefMapper = chiefMapper;
            _instrumentMapper = instrumentMapper;
            _instrumentService = instrumentService;
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
        //_instrumentService.GetAllInstruments()
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
            int finalCookingTime = (order.OrderedFood.CookingTime / chiefToOperate.Level) +
                                   _instrumentService.InstrumentWarmingChecker(chiefToOperate.Instrument);
            DateTime orderBeReady = DateTime.Now.AddSeconds(finalCookingTime);
            if (DateTime.Now == orderBeReady)
            {
                chiefToOperate.IsFree = true;
                chiefToOperate.Instrument.IsInstrumentFree = true;
            }
            return orderBeReady;
        }
    }
}