using System;
using Domain;
namespace RestaurantProject
{
    public class MainProgram
    {
        static public void Main(string[] args)
        {
            Chief newChief = new LowLevelChief();
            Console.WriteLine(newChief.ChiefLevel);
            Chief newChiefNext = new HighLevelChief();
            Console.WriteLine(newChiefNext.ChiefLevel);
        }
    }
}