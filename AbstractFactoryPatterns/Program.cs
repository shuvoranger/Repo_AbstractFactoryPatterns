using System;
namespace AbstractFactoryPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------initialization -------------------------------
            AsbtractFactory seaFactory = AbstractFactoryProduction.GetFactory("SeaVehicleFactory");
            IVehiclecs ivehiclecsSea = seaFactory.GetSeaVehicles("ship");
            Console.WriteLine(ivehiclecsSea.GetEngineInfo());
            IVehiclecs ivehiclecsSea1 = seaFactory.GetSeaVehicles("oil tanker");
            Console.WriteLine(ivehiclecsSea1.GetEngineInfo());
            //--------------------For Air--------------------------------
            AsbtractFactory airFactory = AbstractFactoryProduction.GetFactory("AirVehicleFactory");
            IVehiclecs ivehiclecsAir = airFactory.GetAirVehicles("AirPlane");
            Console.WriteLine(ivehiclecsAir.GetEngineInfo());
            IVehiclecs ivehiclecsAir1 = airFactory.GetAirVehicles("Helicopter");
            Console.WriteLine(ivehiclecsAir1.GetEngineInfo());
            //--------------------For Road--------------------------------
            AsbtractFactory roadFactory = AbstractFactoryProduction.GetFactory("RoadVehicleFactory");
            IVehiclecs ivehiclecsRoad = roadFactory.GetRoadVehicles("Car");
            Console.WriteLine(ivehiclecsRoad.GetEngineInfo());
            IVehiclecs ivehiclecsRoad1 = roadFactory.GetRoadVehicles("Bus");
            Console.WriteLine(ivehiclecsRoad1.GetEngineInfo());
            Console.ReadKey();
        }
    }
}
