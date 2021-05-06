using System.Collections.Generic;
using Entities;

namespace Mapper
{
    public static class ChiefMapper
    {
        public static ChiefEntity ToEntity(this Chief chief)
        {
            return new ChiefEntity
            {
                Age = chief.Age,
                Name = chief.Name,
                Level = chief.Level
            };
        }
    }
}