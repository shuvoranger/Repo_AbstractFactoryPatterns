using System;
namespace AbstractFactoryPatterns
{
    abstract class AsbtractFactory
    {
        public abstract IVehiclecs GetSeaVehicles(String type);
        public abstract IVehiclecs GetAirVehicles(String type);
        public abstract IVehiclecs GetRoadVehicles(String type);
    }
}
