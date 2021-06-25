using Restaurant.BL.Models;
using Restaurant.DAL.Entities;

namespace Restaurant.BL.Mappers
{
    public static class ChiefMakesOrderMapper
    {
        public static ChiefMakesOrderEntity convertToEntity(this ChiefMakesOrder model)
        {
            return new ChiefMakesOrderEntity { 
            // TODO add realization
            };
        }

        public static ChiefMakesOrder convertToModel(this ChiefMakesOrderEntity entity)
        {
            return new ChiefMakesOrder { 
                // TODO add realization
            };
        }
    }
}