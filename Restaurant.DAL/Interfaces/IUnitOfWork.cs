namespace Restaurant.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
        IChiefRepository ChiefRepository { get; }
        IChiefMakesFoodRepository ChiefMakesFoodRepository { get; }
        IChiefUseInstrumentRepository ChiefUseInstrumentRepository { get; }
        IFoodRepository FoodRepository { get; }
        IInstrumentRepository InstrumentRepository { get; }
    }
}