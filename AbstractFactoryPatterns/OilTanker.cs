using System;
namespace AbstractFactoryPatterns
{
    class OilTanker:IVehiclecs
    {
        public string GetEngineInfo()
        {
            return "Siemen’s 340 MW Gas Turbine";
        }
    }
}
