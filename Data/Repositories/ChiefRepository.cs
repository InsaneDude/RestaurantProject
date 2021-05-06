using System.Collections.Generic;
using Data.Repositories.Abstract;
using Entities;


namespace Data.Repositories
{
    public class ChiefRepository : IChiefRepository
    {
        private static List<ChiefEntity> _list = new List<ChiefEntity>();
        public void AddChief(ChiefEntity chief)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateChief(ChiefEntity chief)
        {
            throw new System.NotImplementedException();
        }

        public List<ChiefEntity> GetAllChiefs()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteChiefById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}