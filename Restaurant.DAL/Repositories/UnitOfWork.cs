using System;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private RestaurantDBContext context;
        private bool isDisposed;
        
        public UnitOfWork(RestaurantDBContext context, 
        IChiefRepository chiefRepository,
        IFoodRepository foodRepository,
        IInstrumentRepository instrumentRepository,
        IMenuRepository menuRepository,
        IOrderRepository orderRepository)
        {
            this.context = context;
            ChiefRepository = chiefRepository;
            FoodRepository = foodRepository;
            InstrumentRepository = instrumentRepository;
            MenuRepository = menuRepository;
            OrderRepository = orderRepository;
        }
        ~UnitOfWork() { Dispose(false); }
        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(isDisposed) { return; }
            if(disposing) { context.Dispose(); }
            isDisposed = true;
        }
        public void Save()
        {
            context.SaveChanges();
        }
        public IChiefRepository ChiefRepository { get; }
        public IFoodRepository FoodRepository { get; }
        public IInstrumentRepository InstrumentRepository { get; }
        public IMenuRepository MenuRepository { get; }
        public IOrderRepository OrderRepository { get; }
    }
}