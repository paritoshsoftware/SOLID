
namespace NullPointerException
{
    public class VehicleFactory
    {
        string vehicleType = string.Empty;
        public VehicleFactory(string vehicleType)
        {
                this.vehicleType = vehicleType;
        }
       
        public IVehicle GetVehicle() {
            
        
            switch (this.vehicleType)
            {
                case "Car":
                    return new Car();

                case "Bike":
                    return new Bike();

                case "Bus":
                    return new Bus();

                
                default:
                    return new NullObject();

            }
        
        }
    }
}
