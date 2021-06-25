using System;

namespace Restaurant.DAL.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
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