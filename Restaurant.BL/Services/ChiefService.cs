using System;
using System.Collections.Generic;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Entities;
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
            List<ChiefEntity> chiefToSelect = _unitOfWork.ChiefRepository.GetAll();
            foreach (var chiefNow in _unitOfWork.ChiefRepository.GetAll())
            {
                if (chiefNow.IsFree is true)
                {
                    chiefNow.IsFree = false;
                    chiefToFind = _chiefMapper.convertToModel(chiefNow);
                    break;
                }
            }
            return chiefToFind;
        }

        private Chief ChiefSelectsInstrument()
        {
            Chief chiefToGiveInstrument = ChiefSelecting();
            foreach (var instrumentNow in _instrumentService.GetAllInstruments())
            {
                if (instrumentNow.IsInstrumentFree is true)
                {
                    chiefToGiveInstrument.Instrument = instrumentNow;
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