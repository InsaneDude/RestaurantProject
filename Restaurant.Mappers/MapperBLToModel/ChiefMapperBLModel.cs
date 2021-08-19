using Restaurant.BLModels.Models;
using Restaurant.Mappers.MapperBLToModel.Interfaces;
using Restaurant.WPF.Models;

namespace Restaurant.Mappers.MapperBLToModel
{
    public class ChiefMapperBLModel : IChiefMapperBLModel
    {
        private IInstrumentMapperBLModel _instrumentMapperBLModel;

        public ChiefMapperBLModel(IInstrumentMapperBLModel instrumentMapperBLModel)
        {
            _instrumentMapperBLModel = instrumentMapperBLModel;
        }
        public ChiefModel convertToModel(Chief mod)
        {
            return new ChiefModel
            { 
                Name = mod.Name, 
                Level = mod.Level, 
                IsFree = mod.IsFree, 
                Id = mod.Id,
                Instrument = _instrumentMapperBLModel.convertToModel(mod.Instrument),
            };
        }

        public Chief convertToBLMod(ChiefModel model)
        {
            if (model.Instrument != null)
            {
                return new Chief 
                { 
                    Name = model.Name, 
                    Level = model.Level,
                    IsFree = model.IsFree, 
                    Id = model.Id,
                    Instrument = _instrumentMapperBLModel.convertToBLMod(model.Instrument)
                };
            }
            return new Chief 
            { 
                Name = model.Name, 
                Level = model.Level,
                IsFree = model.IsFree,
                Id = model.Id
            };
        }
    }
}