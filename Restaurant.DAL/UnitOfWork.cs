using Restaurant.DAL.Interfaces;

namespace Restaurant.DAL
{
    public class UnitOfWork: IUnitOfWork
    {
        private RestaurantDBContext context;
        
        public UnitOfWork(RestaurantDBContext context, 
        IChiefRepository chiefRepository,
        IChiefMakesFoodRepository chiefMakesFoodRepository,
        IChiefUseInstrumentRepository chiefUseInstrumentRepository,
        IFoodRepository foodRepository,
        IInstrumentRepository instrumentRepository)
        {
            this.context = context;
            ChiefRepository = chiefRepository;
            ChiefMakesFoodRepository = chiefMakesFoodRepository;
            ChiefUseInstrumentRepository = chiefUseInstrumentRepository;
            FoodRepository = foodRepository;
            InstrumentRepository = instrumentRepository;
        }
        
        public void Save()
        {
            context.SaveChanges();
        }

        public IChiefRepository ChiefRepository { get; }
        public IChiefMakesFoodRepository ChiefMakesFoodRepository { get; }
        public IChiefUseInstrumentRepository ChiefUseInstrumentRepository { get; }
        public IFoodRepository FoodRepository { get; }
        public IInstrumentRepository InstrumentRepository { get; }
    }
}