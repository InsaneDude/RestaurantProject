using Restaurant.BL.Models;
using Restaurant.DAL.Entities;


namespace Restaurant.BL.Mappers
{
    public static class ChiefUseInstrumentMapper
    {
        public static ChiefUseInstrumentEntity convertToEntity(this ChiefUseInstrument model)
        {
            return new ChiefUseInstrumentEntity
            {
                // TODO realiz
            };
        }

        public static ChiefUseInstrument convertToModel(this OrderEntity entity)
        {
            return new ChiefUseInstrument
            { 
                // TODO realiz
            };
        }
    }
}