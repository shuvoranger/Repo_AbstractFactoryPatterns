using System;
namespace AbstractFactoryPatterns
{
    class Ship:IVehiclecs
    {
        public string GetEngineInfo()
        {
            return "Wartsila-Sulzer RTA96-C turbocharged two-stroke diesel ship engine";
        }
    }
}
