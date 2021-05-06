using System.Collections.Generic;
using Entities;

namespace Services.Abstract
{
    public class IChiefsService
    {
        void AddChief(ChiefEntity chief);
        void UpdateChief(ChiefEntity chief);
        List<ChiefEntity> GetAllChiefs();
        void DeleteChiefById(int id);
    }
}