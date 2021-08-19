using System;
using System.Collections.Generic;
using Restaurant.BLModels.Models;
using Restaurant.BL.Services.Abstract;
using Restaurant.DAL.Repositories.Interfaces;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;

namespace Restaurant.BL.Services
{
    public class InstrumentService : IInstrumentService
    {
        private IUnitOfWork _unitOfWork;
        private IInstrumentMapper _instrumentMapper;

        public InstrumentService(IUnitOfWork unitOfWork, IInstrumentMapper instrumentMapper)
        {
            _instrumentMapper = instrumentMapper;
            _unitOfWork = unitOfWork;
        }

        public List<Instrument> GetAllInstruments()
        {
            List<Instrument> instrumentList = new List<Instrument>();
            foreach (var instrumentNow in _unitOfWork.InstrumentRepository.GetAll())
            {
                instrumentList.Add(_instrumentMapper.convertToModel(instrumentNow));
            }
            return instrumentList;
        }

        public int InstrumentWarmingChecker(Instrument instrument)
        {
            TimeSpan timeToAdd = new TimeSpan(0,0,instrument.WarmingTime);
            if (DateTime.Now > instrument.LastUsageTime + timeToAdd)
            {
                return instrument.WarmingTime;
            }
            else
            {
                return 0;
            }
        }
    }
}