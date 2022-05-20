using System;
namespace AbstractFactoryPatterns
{
    class AirVehicleFactory:AsbtractFactory
    {
        public override IVehiclecs GetSeaVehicles(string type)
        {
            return null;
        }
        public override IVehiclecs GetAirVehicles(string type)
        {
            IVehiclecs ivehiclecs = null;
            if (type.ToLower().Equals("airplane"))
            {
                ivehiclecs = new AirPlane();
            }
            else if (type.ToLower().Equals("helicopter"))
            {
                ivehiclecs = new HeliCopter();
            }
            return ivehiclecs;
        }
        public override IVehiclecs GetRoadVehicles(string type)
        {
            return null;
        }
    }
}
