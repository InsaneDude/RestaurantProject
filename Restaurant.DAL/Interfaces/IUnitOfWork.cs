namespace Restaurant.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        void Save();
        IChiefRepository ChiefRepository { get; }
        IChiefMakesOrderRepository ChiefMakesOrderRepository { get; }
        IChiefUseInstrumentRepository ChiefUseInstrumentRepository { get; }
        IFoodRepository FoodRepository { get; }
        IInstrumentRepository InstrumentRepository { get; }
        IMenuRepository MenuRepository { get; }
        IOrderRepository OrderRepository { get; }
    }
}