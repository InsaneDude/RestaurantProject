using System.Collections.Generic;
using Restaurant.BL.Models;

namespace Restaurant.BL.Services.Abstract
{
    public interface IInstrumentService
    {
        List<Instrument> GetAllInstruments();
        int InstrumentWarmingChecker(Instrument instrument);
    }
}