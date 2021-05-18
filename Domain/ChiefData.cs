using System.Collections.Generic;

namespace Domain
{
    
    public class ChiefData
    {
        private List<Chief> _chiefList = new List<Chief>();

        public ChiefData()
        {
            Chief newChiefFirst = new Chief()
            {
                Age = 25, Name = "Валеска", ChiefLevel = 1, IsFree = true, Id = 1
            };
            AddChief(newChiefFirst);
            
            Chief newChiefSecond = new Chief()
            {
                Age = 33, Name = "Калх", ChiefLevel = 2, IsFree = false, Id = 2
            };
            AddChief(newChiefSecond);
            
            Chief newChiefThird = new Chief()
            {
                Age = 41, Name = "Эоваций", ChiefLevel = 3, IsFree = true, Id = 3
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