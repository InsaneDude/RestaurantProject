using System.Collections.Generic;
using Entities;

namespace Data.Repositories.Abstract
{
    public interface IChiefRepository
    {
        void AddChief(ChiefEntity chief);
        void UpdateChief(ChiefEntity chief);
        List<ChiefEntity> GetAllChiefs();
        void DeleteChiefById(int id);
    }
    
}