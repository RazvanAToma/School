using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamensutfordring
{
    internal class Battery
    {
        private string BatteryID { get; set; }
        private float EnergyLevel { get; set; }     // mAh
        private float EnergyCapacity { get; set; }  // mAh

        public Battery(string batteryID, float energyLevel, float energyCapacity)
        {
            BatteryID = batteryID;
            EnergyLevel = energyLevel;
            EnergyCapacity = energyCapacity;
        }

        public void Charge(float energy)
        {
            try
            {
                ChargeBattery(energy);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
        }

        private void ChargeBattery(float energy)
        {
            if (EnergyCapacity < (EnergyLevel + energy))
            {
                throw new ArgumentOutOfRangeException($"Charge amount of {energy} will exceed {BatteryID}s maximum capacity of {EnergyCapacity} " +
                                                      $"Maximum amount of charge accepted is {EnergyCapacity - EnergyLevel}");
            }
            else if (energy < 0)
            {
                throw new ArgumentOutOfRangeException($"Charge amount of {energy} is not valid. Number must me positive.");
            }   
            else
            {
                Console.WriteLine($"Charging battery with {energy} mAh...");
                EnergyLevel += energy;
            }
        }

        public void Use(float energy)
        {
            try
            {
                UseBattery(energy);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
        }

        private void UseBattery(float energy)
        {
            if ((EnergyLevel - energy) < 0)
            {
                throw new ArgumentOutOfRangeException($"Battery {BatteryID} does not have {energy} mAh available" +
                                                      $"Maximum amount of usage accepted is {EnergyLevel}");
            }
            else if (energy < 0)
            {
                throw new ArgumentOutOfRangeException($"Charge amount of {energy} is not valid. Number must me positive.");
            }
            else
            {
                Console.WriteLine($"Using {energy} mAh...");
                EnergyLevel -= energy;
            }
        }

        public float ShowCharge()
        {
            return EnergyLevel;
        }
    }
}
