        using System;
using Restaurant.DAL.Repositories.Interfaces;

namespace Restaurant.DAL.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly RestaurantDBContext _context;
        private bool _isDisposed;
        
        public UnitOfWork(RestaurantDBContext context, 
        IChiefRepository chiefRepository,
        IFoodRepository foodRepository,
        IInstrumentRepository instrumentRepository,
        IMenuRepository menuRepository,
        IOrderRepository orderRepository)
        {
            _context = context;
            ChiefRepository = chiefRepository;
            FoodRepository = foodRepository;
            InstrumentRepository = instrumentRepository;
            MenuRepository = menuRepository;
            OrderRepository = orderRepository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        
        public IChiefRepository ChiefRepository { get; }
        public IFoodRepository FoodRepository { get; }
        public IInstrumentRepository InstrumentRepository { get; }
        public IMenuRepository MenuRepository { get; }
        public IOrderRepository OrderRepository { get; }
        ~UnitOfWork() { Dispose(false); }
        public void Dispose() 
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if(_isDisposed) { return; }
            if(disposing) { _context.Dispose(); }
            _isDisposed = true;
        }
    }
}