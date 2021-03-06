namespace Restaurant.BL.Mappers.Interfaces
{
    public interface IMapper<TEnt, TMod>
    {
        TEnt convertToEntity(TMod model);
        TMod convertToModel(TEnt entity);
    }
}