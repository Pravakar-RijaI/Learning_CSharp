using System;
using System.Threading;

namespace DrinkWaterProject
{
    public class WaterBottle
    {
        public delegate void WarningLevelExceptionHandler(object source, EventArgs args);
        public event WarningLevelExceptionHandler WarningLevel;

        public string Name { get; set; }
        public double WaterLevel { get; set; }
        public double RemainingWaterLevel { get; set; }

        public void DrinkWater(double qtyofwaterdrank)
        {
            this.RemainingWaterLevel = this.WaterLevel - qtyofwaterdrank;
            Console.WriteLine("Drinking Water...");
            Thread.Sleep(3000);
            Console.WriteLine("Water Drank: " + qtyofwaterdrank + " ounces.");
            Console.WriteLine("Remaning Water: " + this.RemainingWaterLevel + " ounces.\n");

            if (this.RemainingWaterLevel == 0)
                OnWarningLevel();
        }

        protected virtual void OnWarningLevel()
        {
            if (WarningLevel != null)
                WarningLevel(this, EventArgs.Empty);
        }
    }
}
