using System;
using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.BL.Services
{
    public class ChiefUseInstrumentService : IChiefUseInstrumentService
    {
        private IUnitOfWork _unitOfWork;
        private IInstrumentMapper _instrumentMapper;
        private IChiefMapper _chiefMapper;

        public ChiefUseInstrumentService(
            IUnitOfWork unitOfWork,
            IInstrumentMapper instrumentMapper,
            IChiefMapper chiefMapper)
        {
            _unitOfWork = unitOfWork;
            _instrumentMapper = instrumentMapper;
            _chiefMapper = chiefMapper;
        }
        public ChiefUseInstrument ChiefUseInstrumentNow()
        {
            ChiefUseInstrument chiefSelectTool = new ChiefUseInstrument();
            foreach (var chiefAvailable in _unitOfWork.ChiefRepository.GetAll())
            {
                if (chiefAvailable.IsFree is true)
                {
                    chiefSelectTool.Chief = _chiefMapper.convertToModel(chiefAvailable);
                    chiefSelectTool.Chief.IsFree = false;
                    break;
                }
            }
            foreach (var instrumentAvailable in _unitOfWork.InstrumentRepository.GetAll())
            {
                if (instrumentAvailable.IsInstrumentFree is true)
                {
                    chiefSelectTool.Instrument = _instrumentMapper.convertToModel(instrumentAvailable);
                    chiefSelectTool.Instrument.IsInstrumentFree = false;
                    chiefSelectTool.LastUsageTime = DateTime.Now;
                    chiefSelectTool.IsInstrumentReady = true;
                    break;
                }
            }
            return chiefSelectTool;
        }
    }
}