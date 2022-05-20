using System;
namespace AbstractFactoryPatterns
{
    class SeaVehicleFactory:AsbtractFactory
    {
        public override IVehiclecs GetSeaVehicles(string type)
        {
            IVehiclecs ivehiclecs = null;
            if (type.ToLower().Equals("ship"))
            {
                ivehiclecs= new Ship();
            }
            else if (type.ToLower().Equals("oil tanker"))
            {
                ivehiclecs= new OilTanker();
            }
            return ivehiclecs;
        }
        public override IVehiclecs GetAirVehicles(string type)
        {
            return null;
        }
        public override IVehiclecs GetRoadVehicles(string type)
        {
            return null;
        }
    }
}
