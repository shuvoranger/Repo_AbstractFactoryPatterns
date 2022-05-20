using System;
namespace AbstractFactoryPatterns
{
    class RoadVehicleFactory:AsbtractFactory
    {
        public override IVehiclecs GetSeaVehicles(string type)
        {
            return null;
        }
        public override IVehiclecs GetAirVehicles(string type)
        {
            return null;
        }
        public override IVehiclecs GetRoadVehicles(string type)
        {
            IVehiclecs ivehiclecs = null;
            if (type.ToLower().Equals("car"))
            {
                ivehiclecs = new Car();
            }
            else if (type.ToLower().Equals("bus"))
            {
                ivehiclecs = new Bus();
            }
            return ivehiclecs;
        }
    }
}
