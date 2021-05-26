using System.Collections.Generic;

namespace Domain
{
    
    public class ChiefData
    {
        private List<Chief> _chiefList = new List<Chief>();

        public ChiefData()
        {
            Chief newChiefFirst = new LowLevelChief()
            {
                Name = "Валеска", IsFree = false, Id = 1
            };
            AddChief(newChiefFirst);
            
            Chief newChiefSecond = new MidLevelChief()
            {
                Name = "Калх", IsFree = true, Id = 2
            };
            AddChief(newChiefSecond);
            
            Chief newChiefThird = new HighLevelChief()
            {
                Name = "Эоваций", IsFree = true, Id = 3
            };
            AddChief(newChiefThird);
        }
        
        public void AddChief(Chief chiefToAdd)
        {
            _chiefList.Add(chiefToAdd);
        }
        
        public List<Chief> GetAllChiefs()
        {
            return _chiefList;
        }
    }
}