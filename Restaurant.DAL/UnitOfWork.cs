using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class UnitOfWork: IUnitOfWork
    {
        private RestaurantDBContext context;
        
        public UnitOfWork(RestaurantDBContext context, 
        IChiefRepository chiefRepository,
        IChiefMakesOrderRepository chiefMakesOrderRepository,
        IChiefUseInstrumentRepository chiefUseInstrumentRepository,
        IFoodRepository foodRepository,
        IInstrumentRepository instrumentRepository,
        IMenuRepository menuRepository,
        IOrderRepository orderRepository)
        {
            this.context = context;
            ChiefRepository = chiefRepository;
            ChiefMakesOrderRepository = chiefMakesOrderRepository;
            ChiefUseInstrumentRepository = chiefUseInstrumentRepository;
            FoodRepository = foodRepository;
            InstrumentRepository = instrumentRepository;
            MenuRepository = menuRepository;
            OrderRepository = orderRepository;
        }
        
        public void Save()
        {
            context.SaveChanges();
        }

        public IChiefRepository ChiefRepository { get; }
        public IChiefMakesOrderRepository ChiefMakesOrderRepository { get; }
        public IChiefUseInstrumentRepository ChiefUseInstrumentRepository { get; }
        public IFoodRepository FoodRepository { get; }
        public IInstrumentRepository InstrumentRepository { get; }
        public IMenuRepository MenuRepository { get; }
        public IOrderRepository OrderRepository { get; }
    }
}