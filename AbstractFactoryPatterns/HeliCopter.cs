using System;
namespace AbstractFactoryPatterns
{
    class HeliCopter:IVehiclecs
    {
        public string GetEngineInfo()
        {
            return "Lycoming O-360 four-cylinder, carbureted";
        }
    }
}
