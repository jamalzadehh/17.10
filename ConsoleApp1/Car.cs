using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car:IVehicle
    {
        private double MileAge;
        private double Fuel;
        private double FuelConsumption;
        private double TankCapacity;

        public Car(double fuel = 20, double tankCapacity = 40, double fuelConsumption = 10)
        {
            Fuel = fuel;
            TankCapacity = tankCapacity;
            FuelConsumption = fuelConsumption;
        }

        public bool Drive(double kilometers)
        {
            double neededFuel = (kilometers / 100) * FuelConsumption;
            if (neededFuel > Fuel)
            {
                return false;
            }

            Fuel -= neededFuel;
            MileAge += kilometers;
            return true;
        }

        public bool Refuel(double amount)
        {
            if (amount < 0)
            {
                return false;
            }

            Fuel += amount;
            if (Fuel > TankCapacity)
            {
                Fuel = TankCapacity;
            }

            return true;
        }
        public double GetMileAge()
        {
            return MileAge;
        }
    }
}
