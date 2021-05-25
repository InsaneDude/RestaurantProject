using System.Collections.Generic;
using Entities;

namespace Domain
{
    public class InstrumentData
    {
        private List<Instrument> _instrumentList = new List<Instrument>();
        
        public InstrumentData()
        {
            Instrument firstFurnace = new Instrument()
            {
                Name = "Печь №1", IsFree = true, IsReady = false, KeepWarm = 1800, WarmingTime = 900, Id = 1
            };
            AddInstrument(firstFurnace);
            
            Instrument secondFurnace = new Instrument()
            {
                Name = "Печь №2", IsFree = true, IsReady = false, KeepWarm = 1500, WarmingTime = 1000, Id = 2
            };
            AddInstrument(secondFurnace);
        }
        public void AddInstrument(Instrument instrumentToAdd)
        {
            _instrumentList.Add(instrumentToAdd);
        }
        public List<Instrument> GetAllInstruments()
        {
            return _instrumentList;
        }

        // public void UpdateInstrument(Instrument updInstrument)
        // {
        //     for (int i = 0; i < _instrumentList.Count; i++)
        //     {
        //         if (updInstrument.Id == _instrumentList[i].Id)
        //         {
        //             _instrumentList[i] = updInstrument;
        //         }
        //     }
        // }
    }
}