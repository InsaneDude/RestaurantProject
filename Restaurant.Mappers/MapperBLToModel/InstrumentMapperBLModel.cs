using Restaurant.Models;
using Restaurant.Mappers.MapperBLToModel.Interfaces;
using VModels.Models;

namespace Restaurant.Mappers.MapperBLToModel
{
    public class InstrumentMapperBLModel : IInstrumentMapperBLModel
    {
        public InstrumentModel convertToModel(Instrument mod)
        {
            return new InstrumentModel
            {
                Name = mod.Name,
                WarmingTime = mod.WarmingTime,
                IsInstrumentFree = mod.IsInstrumentFree,
                Id = mod.Id,
                LastUsageTime = mod.LastUsageTime
            };
        }
        
        public Instrument convertToBLMod(InstrumentModel model)
        {
            return new Instrument
            {
                Name = model.Name, 
                WarmingTime = model.WarmingTime,
                IsInstrumentFree = model.IsInstrumentFree,
                Id = model.Id,
                LastUsageTime = model.LastUsageTime
            };
        }
    }
}