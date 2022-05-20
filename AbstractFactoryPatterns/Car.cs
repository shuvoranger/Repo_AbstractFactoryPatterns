using System;
namespace AbstractFactoryPatterns
{
    class Car:IVehiclecs
    {
        public string GetEngineInfo()
        {
            return "2-Gen,Twin Cam Diesal Engine (Prosmatic)";
        }
    }
}
