using Restaurant.BL.Mappers.Interfaces;
using Restaurant.BL.Models;
using Restaurant.DAL.Entities;


namespace Restaurant.BL.Mappers
{
    public class ChiefMapper : IChiefMapper
    {
        private IInstrumentMapper _instrumentMapper;

        public ChiefMapper(IInstrumentMapper instrumentMapper)
        {
            _instrumentMapper = instrumentMapper;
        }
        public ChiefEntity convertToEntity(Chief model)
        {
            return new ChiefEntity 
            { 
                Name = model.Name, 
                Level = model.Level, 
                IsFree = model.IsFree, 
                Id = model.Id,
                Instrument = _instrumentMapper.convertToEntity(model.Instrument),
            };
        }

        public Chief convertToModel(ChiefEntity entity)
        {
            if (entity.Instrument != null)
            {
                return new Chief 
                { 
                    Name = entity.Name, 
                    Level = entity.Level, // error
                    IsFree = entity.IsFree, 
                    Id = entity.Id,
                    Instrument = _instrumentMapper.convertToModel(entity.Instrument)
                };
            }
            return new Chief 
            { 
                Name = entity.Name, 
                Level = entity.Level, // error
                IsFree = entity.IsFree,
                Id = entity.Id
            };
        }
    }
}