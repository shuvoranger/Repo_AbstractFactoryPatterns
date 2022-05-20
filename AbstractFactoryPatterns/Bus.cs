using System;
namespace AbstractFactoryPatterns
{
    class Bus:IVehiclecs
    {
        public string GetEngineInfo()
        {
            return "Rear-mounted, 6-cylinder,7-litre diesel";
        }
    }
}
