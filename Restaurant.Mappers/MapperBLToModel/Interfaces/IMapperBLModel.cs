namespace Restaurant.Mappers.MapperBLToModel.Interfaces
{
    public interface IMapperBLModel<TMod, TModel>
    {
        TMod convertToBLMod(TModel model);
        TModel convertToModel(TMod mod);
    }
}