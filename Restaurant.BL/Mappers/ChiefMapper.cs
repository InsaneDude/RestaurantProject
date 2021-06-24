using Entities;
using Restaurant.Models;


namespace Restaurant.BL.Mappers
{
    public static class ChiefMapper
    {
        public static ChiefEntity convertToEntity(this Chief model)
        {
            return new ChiefEntity { 
                Name = model.Name, 
                Level = model.Level, 
                IsFree = model.IsFree, 
                Id = model.Id };
        }

        public static Chief convertToModel(this ChiefEntity entity)
        {
            return new Chief { 
                Name = entity.Name, 
                Level = entity.Level, 
                IsFree = entity.IsFree, 
                Id = entity.Id };
        }
    }
}