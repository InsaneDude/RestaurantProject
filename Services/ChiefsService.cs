using System.Collections.Generic;
using Entities;
using Services.Abstract;

namespace Services
{
    public class ChiefsService : IChiefsService
    {
        private readonly IChiefsRepository chiefsRepository;

        public ChiefsService(IChiefsService chiefsService)
        {
            _chiefsRepository = chiefsRepository;
        }
        
        void AddChief(ChiefEntity chief)
        {
            throw new System.NotImplementedException();
        }

        void UpdateChief(ChiefEntity chief)
        {
            throw new System.NotImplementedException();
        }

        List<ChiefEntity> GetAllChiefs()
        {
            throw new System.NotImplementedException();
        }

        void DeleteChiefById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}