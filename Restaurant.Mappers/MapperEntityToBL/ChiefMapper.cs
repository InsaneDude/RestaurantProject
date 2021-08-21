using Restaurant.Models;
using Restaurant.DAL.Entities;
using Restaurant.Mappers.MapperEntityToBL.Interfaces;

namespace Restaurant.Mappers.MapperEntityToBL
{
    public class ChiefMapper : IChiefMapper
    {
        private readonly IInstrumentMapper _instrumentMapper;

        public ChiefMapper(IInstrumentMapper instrumentMapper)
        {
            _instrumentMapper = instrumentMapper;
        }
        public ChiefEntity convertToEntity(Chief model)
        {
            if (model.Instrument != null)
            {
                return new ChiefEntity 
                { 
                    Name = model.Name, // ?
                    Level = model.Level,
                    IsFree = model.IsFree, 
                    Id = model.Id,
                    Instrument = _instrumentMapper.convertToEntity(model.Instrument)
                };
            }
            return new ChiefEntity 
            { 
                Name = model.Name, 
                Level = model.Level,
                IsFree = model.IsFree,
                Id = model.Id
            };
        }

        public Chief convertToModel(ChiefEntity entity)
        {
            if (entity.Instrument != null)
            {
                return new Chief 
                { 
                    Name = entity.Name, 
                    Level = entity.Level,
                    IsFree = entity.IsFree, 
                    Id = entity.Id,
                    Instrument = _instrumentMapper.convertToModel(entity.Instrument)
                };
            }
            return new Chief 
            {
                Name = entity.Name, 
                Level = entity.Level,
                IsFree = entity.IsFree,
                Id = entity.Id
            };
        }
    }
}