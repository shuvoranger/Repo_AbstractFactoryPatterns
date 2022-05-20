using System;
namespace AbstractFactoryPatterns
{
    class AbstractFactoryProduction
    {
        public static AsbtractFactory GetFactory(String Name)
        {
           AsbtractFactory asbtractFactory = null;
            if (Name.ToLower().Equals("seavehiclefactory"))
            {
                asbtractFactory=new SeaVehicleFactory();
            }
            else if (Name.ToLower().Equals("airvehiclefactory"))
            {
                asbtractFactory = new AirVehicleFactory();
            }
            else if (Name.ToLower().Equals("roadvehiclefactory"))
            {
                asbtractFactory = new RoadVehicleFactory();
            }
            return asbtractFactory;
        }
    }
}
