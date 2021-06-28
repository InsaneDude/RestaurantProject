using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.DAL.Entities;

namespace Restaurant.BL.Mappers
{
    public class InstrumentMapper : IInstrumentMapper
    {
        public InstrumentEntity convertToEntity(Instrument model)
        {
            return new InstrumentEntity
            {
                Name = model.Name, 
                WarmingTime = model.WarmingTime, 
                IsInstrumentFree = model.IsInstrumentFree,
                Id = model.Id,
                LastUsageTime = model.LastUsageTime
            };
        }

        public Instrument convertToModel(InstrumentEntity entity)
        {
            return new Instrument
            {
                Name = entity.Name, 
                WarmingTime = entity.WarmingTime,
                IsInstrumentFree = entity.IsInstrumentFree,
                Id = entity.Id,
                LastUsageTime = entity.LastUsageTime
            };        
        }
    }
}