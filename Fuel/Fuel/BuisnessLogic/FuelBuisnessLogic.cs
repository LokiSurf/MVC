using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fuel.BuisnessLogic
{
    public class FuelBuisnessLogic
    {
        public double CalculateAvgConsumption(int fuel, int distance)
        {
            double avg = ((double) fuel / distance) * 100;
            return avg;
        }
    }
}