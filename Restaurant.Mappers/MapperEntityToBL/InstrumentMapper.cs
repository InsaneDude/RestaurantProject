using Restaurant.Models;
using Restaurant.DAL.Entities;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;

namespace Restaurant.Mappers.MapperEntityToBL
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
            { // error all
                Name = entity.Name, 
                WarmingTime = entity.WarmingTime,
                IsInstrumentFree = entity.IsInstrumentFree,
                Id = entity.Id,
                LastUsageTime = entity.LastUsageTime
            };
        }
    }
}