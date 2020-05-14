using System;
using Models;

namespace HomeWork7
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricCar Car1 = new ElectricCar(10, "prv", "prv", 3, 200, Consumption.medium, 100, 50);
            FuelCar Car2 = new FuelCar(50, "vtor", "vtor", 5, 220, Consumption.high, EngineType.diesel, 200, 160);
            Car1.PrintInfo();
            Car2.PrintInfo();
            Car1.Drive(100);
            Car1.Drive(400);
            Car1.Recharge(60);
            Car1.Recharge(50);
            Car2.Drive(200);
            Car2.Drive(600);
            Car2.Refuel(130);
            Car2.Refuel(130);
            Car1.PrintInfo();
            Car2.PrintInfo();
        }
    }
}