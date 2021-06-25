using Restaurant.BL.Models;
using Restaurant.DAL.Entities;

namespace Restaurant.BL.Mappers
{
    public static class InstrumentMapper
    {
        public static InstrumentEntity convertToEntity(this Instrument model)
        {
            return new InstrumentEntity
            {
                Name = model.Name, 
                WarmingTime = model.WarmingTime, 
                Id = model.Id
            };
        }

        public static Instrument convertToModel(this InstrumentEntity entity)
        {
            return new Instrument
            {
                Name = entity.Name, 
                WarmingTime = entity.WarmingTime, 
                Id = entity.Id
            };        
        }
    }
}